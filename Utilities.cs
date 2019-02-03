using System.IO;
using System.Linq;

namespace MusicBeePlugin
{
    public class Utilities
    {
        // Remove bucket prefix from path
        public string FormatDir(string dir)
        {
            return dir.Split(':')[1].Substring(1);
        }

        // return the value of ini property
        public string GetIniValue(string value)
        {
            return value.Split('=')[1];
        }

        // Hack
        // This is based upon the assumption that the user has their library
        // stored in the following format /music-library/artists/albums/tracks.wav
        // dropping the last 4 things gets the path to the library
        public string GetLibraryLocation(string file)
        {
            const int LEVELS = 4;
            string[] path = file.Split('\\');
            string[] slicedArray = path.Take(path.Length - LEVELS).ToArray();
            return string.Join("/", slicedArray) + "/";
        }

        // Only return the artist/album/track.wav part of a path
        public string RemovePath(string file)
        {
            const int LEVELS = 3;
            string[] path = file.Split('\\');
            string[] slicedArray = path.Skip(path.Length - LEVELS).ToArray();
            return string.Join("/", slicedArray);
        }

        // Write TotalFiles to SyncSetting.ini
        public void WriteTotalToIni(string file, int totalFiles)
        {
            string[] arrLine = File.ReadAllLines(file);
            arrLine[3] = $"numFiles={totalFiles}";
            File.WriteAllLines(file, arrLine);
        }

        public string GetAlbumName(string file)
        {
            string noPath = RemovePath(file);
            string[] slicedArray = noPath.Split('/');
            return slicedArray[1];
        }
    }
}