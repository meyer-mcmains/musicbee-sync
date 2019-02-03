using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using static MusicBeePlugin.Plugin;

namespace MusicBeePlugin
{
    internal class Notify
    {
        private readonly Utilities utils = new Utilities();
        private IAmazonS3 s3Client;
        private MusicBeeApiInterface mbApiInterface;
        private string s3Bucket;
        private static readonly string subject = "Music Library Update";
        private static readonly int fullSize = 480;
        private static readonly int thumbSize = 150;

        public void SendNotification(MusicBeeApiInterface mbApi, string[] settings, IAmazonS3 s3, List<string> newFiles, List<string> updatedFiles)
        {
            s3Client = s3;
            mbApiInterface = mbApi;
            string bucketRegion = utils.GetIniValue(settings[0]);
            s3Bucket = utils.GetIniValue(settings[5]);
            string emailSendFrom = utils.GetIniValue(settings[6]);
            string emailSendTo = utils.GetIniValue(settings[7]);

            using (var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.GetBySystemName(bucketRegion)))
            {
                var sendRequest = new SendEmailRequest
                {
                    Source = emailSendFrom,
                    Destination = new Destination
                    {
                        ToAddresses = new List<string>(emailSendTo.Split(' '))
                    },
                    Message = new Message
                    {
                        Subject = new Content(subject),
                        Body = new Body
                        {
                            Html = new Content
                            {
                                Charset = "UTF-8",
                                Data = PopulateBody(newFiles, updatedFiles)
                            }
                        }
                    },
                };
                try
                {
                    Debug.WriteLine("Sending email using Amazon SES...");
                    var response = client.SendEmail(sendRequest);
                    Debug.WriteLine("The email was sent successfully.");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("The email was not sent.");
                    Debug.WriteLine("Error message: " + ex.Message);
                }
            }
        }

        private string PopulateBody(List<string> newFiles, List<string> updatedFiles)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var resourceName = "MusicBeePlugin.Email.html";

            string body = string.Empty;
            string title = string.Empty;
            string newTitle = string.Empty;
            string updatedTitle = string.Empty;
            List<string> newAlbums = GetAlbums(newFiles, fullSize);
            List<string> updatedAlbums = GetAlbums(updatedFiles, thumbSize);

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                body = reader.ReadToEnd();
            }

            if (newAlbums.Count > 0 && updatedAlbums.Count > 0)
            {
                title = "Your Music Library Has Been Updated";
                newTitle = $"{newAlbums.Count} New Album{(newAlbums.Count > 1 ? "s" : "")}...";
                updatedTitle = $"{updatedAlbums.Count} Album{(updatedAlbums.Count > 1 ? "s" : "")} Updated...";
            }
            else if (newAlbums.Count > 0)
            {
                if (newAlbums.Count > 1)
                {
                    title = $"{newAlbums.Count} Albums Added To Your Music Library";
                }
                else
                {
                    title = $"A New Album Is Avaliable";
                }
            }
            else
            {
                if (updatedAlbums.Count > 1)
                {
                    title = $"{updatedAlbums.Count} Albums Updated In Your Music Library";
                }
                else
                {
                    title = $"A Album Has Been Updated";
                }
            }

            body = body.Replace("{title}", title);
            body = body.Replace("{newTitle}", newTitle);
            body = body.Replace("{updatedTitle}", updatedTitle);

            string newAlbumImages = null;
            foreach (string album in newAlbums)
            {
                newAlbumImages += $"<p style='font-size: 18px; color: #fff;'>{album}</p>";
                newAlbumImages += FormatNewAlbum(NewCoverKey(album));
            }
            body = body.Replace("{newAlbums}", newAlbumImages);

            string updatedAlbumImages = null;
            foreach (string album in updatedAlbums)
            {
                updatedAlbumImages += FormatUpdatedAlbum(UpdatedCoverKey(album));
            }
            body = body.Replace("{updatedAlbums}", updatedAlbumImages);

            return body;
        }

        private string FormatNewAlbum(string url)
        {
            return $"<img src='{url}' style='border: none; -ms-interpolation-mode: bicubic; max-width: 100% margin-bottom: 10px; width: {fullSize}px;' width='{fullSize}'>";
        }

        private string FormatUpdatedAlbum(string url)
        {
            return $"<img src='{url}' style='border: none; -ms-interpolation-mode: bicubic; max-width: 100%; margin: 5px; width: {thumbSize}px;' width='{thumbSize}'>";
        }

        private List<string> GetAlbums(List<string> newFiles, int size)
        {
            List<string> albums = new List<string>();
            foreach (string file in newFiles)
            {
                string album = utils.GetAlbumName(file);
                if (!albums.Contains(album))
                {
                    UploadCover(file, album, size);
                    albums.Add(utils.GetAlbumName(file));
                }
            }
            return albums;
        }

        private void UploadCover(string file, string album, int size)
        {
            PictureLocations pictureLocations = PictureLocations.None;
            string pictureUrl = null;
            byte[] image = null;
            mbApiInterface.Library_GetArtworkEx(file, 0, true, ref pictureLocations, ref pictureUrl, ref image);

            MemoryStream ms = new MemoryStream(image);
            Image cover = Image.FromStream(ms).GetThumbnailImage(size, size, ThumbnailCallback, IntPtr.Zero);
            Stream stream = new MemoryStream();
            cover.Save(stream, ImageFormat.Jpeg);

            TransferUtility transferUitlity = new TransferUtility(s3Client);
            transferUitlity.Upload(stream, s3Bucket, (size == fullSize) ? NewCoverKey(album) : UpdatedCoverKey(album));
        }

        private bool ThumbnailCallback()
        {
            return false;
        }

        private string NewCoverKey(string albumName)
        {
            return $"https://s3.amazonaws.com//{s3Bucket}/covers/{albumName.Replace(" ", "").ToLower()}.jpg";
        }

        private string UpdatedCoverKey(string albumName)
        {
            return $"https://s3.amazonaws.com//{s3Bucket}/covers/{albumName.Replace(" ", "").ToLower()}-thumb.jpg";
        }
    }
}