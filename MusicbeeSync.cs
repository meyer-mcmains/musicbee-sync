﻿using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.IO;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicBeePlugin
{
    public partial class Plugin
    {
        private MusicBeeApiInterface mbApiInterface;
        private PluginInfo about = new PluginInfo();
        private Utilities utils = new Utilities();
        private readonly string configFile = "SyncSettings.ini";

        public PluginInfo Initialise(IntPtr apiInterfacePtr)
        {
            mbApiInterface = new MusicBeeApiInterface();
            mbApiInterface.Initialise(apiInterfacePtr);
            about.PluginInfoVersion = PluginInfoVersion;
            about.Name = "Musicbee Sync";
            about.Description = "Syncs Musicbee with Amazon S3 Storage";
            about.Author = "Meyer McMains";
            about.TargetApplication = "";   // current only applies to artwork, lyrics or instant messenger name that appears in the provider drop down selector or target Instant Messenger
            about.Type = PluginType.General;
            about.VersionMajor = 1;  // your plugin version
            about.VersionMinor = 0;
            about.Revision = 1;
            about.MinInterfaceVersion = MinInterfaceVersion;
            about.MinApiRevision = MinApiRevision;
            about.ReceiveNotifications = (ReceiveNotificationFlags.PlayerEvents | ReceiveNotificationFlags.TagEvents);
            about.ConfigurationPanelHeight = 75;   // height in pixels that musicbee should reserve in a panel for config settings. When set, a handle to an empty panel will be passed to the Configure function
            return about;
        }

        private ComboBox bucketRegionComboBox;
        private TextBox bucketNameTxtBox;
        private TextBox libraryRootTxtBox;
        private int totalFiles = 0;

        public bool Configure(IntPtr panelHandle)
        {
            // save any persistent settings in a sub-folder of this path
            string dataPath = $"{mbApiInterface.Setting_GetPersistentStoragePath()}{configFile}";

            // panelHandle will only be set if you set about.ConfigurationPanelHeight to a non-zero value
            // keep in mind the panel width is scaled according to the font the user has selected
            // if about.ConfigurationPanelHeight is set to 0, you can display your own popup window
            if (panelHandle != IntPtr.Zero)
            {
                Panel configPanel = (Panel)Panel.FromHandle(panelHandle);

                // bucketRegion
                Label bucketRegionLabel = new Label();
                bucketRegionLabel.AutoSize = true;
                bucketRegionLabel.Location = new Point(0, 5);
                bucketRegionLabel.Text = "Bucket Region";
                bucketRegionComboBox = new ComboBox();
                bucketRegionComboBox.Bounds = new Rectangle(90, 0, 200, bucketRegionComboBox.Height);
                foreach (var region in RegionEndpoint.EnumerableAllRegions)
                {
                    bucketRegionComboBox.Items.Add(region.SystemName);
                }

                // bucketName
                Label bucketNameLabel = new Label();
                bucketNameLabel.AutoSize = true;
                bucketNameLabel.Location = new Point(0, 30);
                bucketNameTxtBox = new TextBox();
                bucketNameLabel.Text = "Bucket Name";
                bucketNameTxtBox.Bounds = new Rectangle(90, 25, 200, bucketNameTxtBox.Height);

                // libraryRoot
                Label libraryRootLabel = new Label();
                libraryRootLabel.AutoSize = true;
                libraryRootLabel.Location = new Point(0, 55);
                libraryRootLabel.Text = "Library Root";
                libraryRootTxtBox = new TextBox();
                libraryRootTxtBox.Bounds = new Rectangle(90, 50, 200, libraryRootTxtBox.Height);

                // load settings from ini
                if (File.Exists(dataPath))
                {
                    string[] config = File.ReadAllLines(dataPath);
                    bucketRegionComboBox.SelectedItem = utils.GetIniValue(config[0]);
                    bucketNameTxtBox.Text = utils.GetIniValue(config[1]);
                    libraryRootTxtBox.Text = utils.GetIniValue(config[2]);
                    totalFiles = Convert.ToInt16(utils.GetIniValue(config[3]));
                }

                // add the controls
                configPanel.Controls.AddRange(new Control[] { bucketRegionLabel, bucketRegionComboBox, bucketNameLabel, bucketNameTxtBox, libraryRootLabel, libraryRootTxtBox });
            }
            return false;
        }

        // called by MusicBee when the user clicks Apply or Save in the MusicBee Preferences screen.
        public void SaveSettings()
        {
            string dataPath = $"{mbApiInterface.Setting_GetPersistentStoragePath()}{configFile}";
            File.WriteAllLines(dataPath, new string[] { $"bucketRegion={bucketRegionComboBox.SelectedItem}", $"bucketName={bucketNameTxtBox.Text}", $"libraryRoot={libraryRootTxtBox.Text}", $"numFiles={totalFiles}" });
        }

        // MusicBee is closing the plugin (plugin is being disabled by user or MusicBee is shutting down)
        public void Close(PluginCloseReason reason)
        {
        }

        // uninstall this plugin - clean up any persisted files
        public void Uninstall()
        {
            File.Delete($"{mbApiInterface.Setting_GetPersistentStoragePath()}{configFile}");
        }

        // receive event notifications from MusicBee
        // you need to set about.ReceiveNotificationFlags = PlayerEvents to receive all notifications, and not just the startup event
        public void ReceiveNotification(string sourceFileUrl, NotificationType type)
        {
            if (type == NotificationType.PluginStartup)
            {
                CreatePanel();
            }
        }

        private SyncPanel syncPanel;

        private void CreatePanel()
        {
            mbApiInterface.MB_AddMenuItem("mnuTools/Sync", "Sync", syncEvent);
        }

        // Color Components
        private void SetColors()
        {
            Color backgroundColor = System.Drawing.Color.FromArgb(mbApiInterface.Setting_GetSkinElementColour(SkinElement.SkinInputControl, ElementState.ElementStateDefault, ElementComponent.ComponentBackground));
            Color foregroundColor = System.Drawing.Color.FromArgb(mbApiInterface.Setting_GetSkinElementColour(SkinElement.SkinInputPanel, ElementState.ElementStateDefault, ElementComponent.ComponentForeground));

            syncPanel.Bounds = mbApiInterface.MB_GetPanelBounds(PluginPanelDock.MainPanel);
            syncPanel.BackColor = backgroundColor;
            syncPanel.downloadCheckListBox.BackColor = backgroundColor;
            syncPanel.downloadCheckListBox.ForeColor = foregroundColor;
            syncPanel.uploadCheckListBox.BackColor = backgroundColor;
            syncPanel.uploadCheckListBox.ForeColor = foregroundColor;
            syncPanel.startSyncButton.BackColor = backgroundColor;
            syncPanel.startSyncButton.ForeColor = foregroundColor;
            syncPanel.uploadGroup.ForeColor = foregroundColor;
            syncPanel.downloadGroup.ForeColor = foregroundColor;
            syncPanel.startSyncButton.BackColor = backgroundColor;
            syncPanel.startSyncButton.ForeColor = foregroundColor;
            syncPanel.startSyncButton.FlatAppearance.BorderColor = foregroundColor;
            syncPanel.syncProgressBar.ForeColor = foregroundColor;
            syncPanel.logsLabel.ForeColor = foregroundColor;
            syncPanel.bucketNameLabel.ForeColor = foregroundColor;
            syncPanel.bucketRegionLabel.ForeColor = foregroundColor;
            syncPanel.libraryRootLabel.ForeColor = foregroundColor;
            syncPanel.totalFilesLabel.ForeColor = foregroundColor;
            syncPanel.closeButton.ForeColor = foregroundColor;
        }

        private void syncEvent(object sender, EventArgs e)
        {
            syncPanel = new SyncPanel();
            SetColors();
            string dataPath = $"{mbApiInterface.Setting_GetPersistentStoragePath()}{configFile}";
            if (File.Exists(dataPath))
            {
                string[] config = File.ReadAllLines(dataPath);
                foreach (var value in config)
                {
                    if (string.IsNullOrEmpty(utils.GetIniValue(value)))
                        return;
                }
                mbApiInterface.MB_AddPanel(syncPanel, PluginPanelDock.MainPanel);
                syncPanel.bucketRegionLabel.Text = $"Bucket Region: {utils.GetIniValue(config[0])}";
                syncPanel.bucketNameLabel.Text = $"Bucket Name: {utils.GetIniValue(config[1])}";
                syncPanel.libraryRootLabel.Text = $"Library Root: {utils.GetIniValue(config[2])}";
                syncPanel.totalFilesLabel.Text = $"Total Files: {utils.GetIniValue(config[3])}";
                syncPanel.startSyncButton.Click += startSyncClick;
                syncPanel.closeButton.Click += closeButtonClick;
            }
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            stop = true;
            mbApiInterface.MB_RemovePanel(syncPanel);
            syncPanel.Dispose();
        }

        private void startSyncClick(object sender, EventArgs e)
        {
            SyncAsync();
        }

        private List<string> musicLibrary;
        private string libraryLocation = null;
        private IAmazonS3 client;
        private bool stop;

        private async Task SyncAsync()
        {
            stop = false;
            syncPanel.logsLabel.Text = "Starting S3 scan";
            syncPanel.startSyncButton.Enabled = false;
            string dataPath = $"{mbApiInterface.Setting_GetPersistentStoragePath()}{configFile}";

            string[] settings = File.ReadAllLines(dataPath);
            string bucketRegion = utils.GetIniValue(settings[0]);
            string bucketName = utils.GetIniValue(settings[1]);
            string libraryRoot = utils.GetIniValue(settings[2]);
            totalFiles = Convert.ToInt16(utils.GetIniValue(settings[3]));

            string[] library = null;
            CredentialProfileStoreChain chain = new CredentialProfileStoreChain();

            if (chain.TryGetAWSCredentials("default", out AWSCredentials awsCredentials))
            {
                client = new AmazonS3Client(RegionEndpoint.GetBySystemName(bucketRegion));
                mbApiInterface.Library_QueryFilesEx("domain=Library", ref library);
                musicLibrary = library.ToList();
                libraryLocation = utils.GetLibraryLocation(library[0]);

                if (totalFiles == 0)
                {
                    syncPanel.logsLabel.Text = "Determining number of files in S3 bucket";
                    CountFiles(client, bucketName, libraryRoot);
                    syncPanel.logsLabel.Text = $"Number of files to scan is {totalFiles}";
                    utils.WriteTotalToIni(dataPath, totalFiles);
                    syncPanel.syncProgressBar.Maximum = totalFiles;
                    syncPanel.totalFilesLabel.Text = $"Total Files: {totalFiles}";
                }
                else
                {
                    syncPanel.syncProgressBar.Maximum = totalFiles;
                }

                totalFiles = 0;
                await ListRemoteLibrary(client, bucketName);
                utils.WriteTotalToIni(dataPath, totalFiles);

                foreach (var file in musicLibrary)
                {
                    syncPanel.uploadCheckListBox.Items.Add(utils.RemovePath(file));
                    syncPanel.logsLabel.Text = $"Adding {utils.RemovePath(file)} to upload list";
                }
                syncPanel.logsLabel.Text = "Finished scanning files";
                PostScan();
            }
        }

        // Recursively Get Total Files in the S3 Bucket
        private void CountFiles(IAmazonS3 client, string bucketName, string directory)
        {
            if (!stop)
            {
                S3DirectoryInfo dirInfo = new S3DirectoryInfo(client, bucketName, directory);
                S3DirectoryInfo[] dirs = dirInfo.GetDirectories();
                if (dirs.Length == 0)
                {
                    S3FileInfo[] files = dirInfo.GetFiles();
                    totalFiles += files.Length;
                    return;
                }
                else
                {
                    Parallel.ForEach(dirs, dir =>
                    {
                        CountFiles(client, bucketName, utils.FormatDir(dir.FullName));
                    });
                }
            }
        }

        // Start Looking Through the bucket
        private async Task ListRemoteLibrary(IAmazonS3 client, string bucketName)
        {
            try
            {
                ListObjectsV2Request request = new ListObjectsV2Request
                {
                    BucketName = bucketName,
                    MaxKeys = 10
                };
                ListObjectsV2Response response;
                do
                {
                    response = await client.ListObjectsV2Async(request);

                    // Process the response.
                    foreach (S3Object entry in response.S3Objects)
                    {
                        if (!stop)
                        {
                            syncPanel.logsLabel.Text = $"Analyzing {entry.Key}";
                            CompareToLocalFile(entry);
                            syncPanel.syncProgressBar.Increment(1);
                            totalFiles++;
                        }
                    }

                    request.ContinuationToken = response.NextContinuationToken;
                } while (response.IsTruncated);
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                syncPanel.logsLabel.Text = $"S3 error occurred. Exception: {amazonS3Exception.ToString()}";
            }
            catch (Exception e)
            {
                syncPanel.logsLabel.Text = $"Exception: { e.ToString()}";
            }
        }

        // Determine Status of File
        private void CompareToLocalFile(S3Object entry)
        {
            Uri uri = new System.Uri(libraryLocation + entry.Key);
            string localPath = uri.LocalPath;
            bool result = musicLibrary.Contains(localPath);
            // File Exists
            if (result)
            {
                FileInfo fileInfo = new FileInfo(localPath);
                // Check if Files are Different
                if (fileInfo.Length != entry.Size && fileInfo.LastWriteTime != entry.LastModified)
                {
                    //Check Which One is Newer
                    if (fileInfo.LastWriteTime > entry.LastModified)
                    {
                        //toUpload.Add(localPath);
                        syncPanel.uploadCheckListBox.Items.Add(utils.RemovePath(localPath));
                        syncPanel.logsLabel.Text = $"Adding {utils.RemovePath(localPath)} to upload list";
                    }
                    else
                    {
                        syncPanel.downloadCheckListBox.Items.Add(utils.RemovePath(localPath));
                        syncPanel.logsLabel.Text = $"Adding {utils.RemovePath(localPath)} to download list";
                    }
                }
                musicLibrary.Remove(localPath);
            }
            // New file
            else
            {
                syncPanel.downloadCheckListBox.Items.Add(utils.RemovePath(localPath));
                syncPanel.logsLabel.Text = $"Adding {utils.RemovePath(localPath)} to download list";
            }
        }

        private void PostScan()
        {
            syncPanel.totalToDownloadLabel.Text = $"Total Files: {syncPanel.downloadCheckListBox.Items.Count.ToString()}";
            syncPanel.totalToUploadLabel.Text = $"Total Files: {syncPanel.uploadCheckListBox.Items.Count.ToString()}";

            if (syncPanel.uploadCheckListBox.Items.Count > 0)
            {
                syncPanel.checkAllUploadButton.Enabled = true;
                syncPanel.unCheckAllUploadButton.Enabled = true;
                syncPanel.checkAllUploadButton.Click += CheckAllButtonClick;
                syncPanel.unCheckAllUploadButton.Click += UnCheckAllButtonClick;
                syncPanel.uploadCheckListBox.ItemCheck += CheckListBoxItemChecked;
                syncPanel.startUploadButton.Click += StartUploadClick;
            }

            if (syncPanel.downloadCheckListBox.Items.Count > 0)
            {
                syncPanel.checkAllDownloadButton.Enabled = true;
                syncPanel.unCheckAllDownloadButton.Enabled = true;
                syncPanel.checkAllDownloadButton.Click += CheckAllButtonClick;
                syncPanel.unCheckAllDownloadButton.Click += UnCheckAllButtonClick;
                syncPanel.downloadCheckListBox.ItemCheck += CheckListBoxItemChecked;
                syncPanel.startDownloadButton.Click += StartDownloadClick;
            }
        }

        private void StartDownloadClick(object sender, EventArgs e)
        {
            syncPanel.downloadTableLayout.Controls.Remove(syncPanel.startDownloadButton);
            string dataPath = $"{mbApiInterface.Setting_GetPersistentStoragePath()}{configFile}";
            string[] settings = File.ReadAllLines(dataPath);
            string bucketName = utils.GetIniValue(settings[1]);
            string libraryRoot = utils.GetIniValue(settings[2]);

            NewProgressBar downloadProgress = new NewProgressBar();
            downloadProgress.Maximum = syncPanel.downloadCheckListBox.CheckedItems.Count;
            downloadProgress.Dock = DockStyle.Fill;
            downloadProgress.ForeColor = System.Drawing.Color.FromArgb(mbApiInterface.Setting_GetSkinElementColour(SkinElement.SkinInputPanel, ElementState.ElementStateDefault, ElementComponent.ComponentForeground));
            syncPanel.downloadTableLayout.Controls.Add(downloadProgress, 0, 2);

            TransferUtility transferUitlity = new TransferUtility(client);
            object[] filesToDownload = new object[syncPanel.downloadCheckListBox.CheckedItems.Count];
            syncPanel.downloadCheckListBox.CheckedItems.CopyTo(filesToDownload, 0);

            foreach (var file in filesToDownload)
            {
                syncPanel.logsLabel.Text = $"Downloading {file}";
                transferUitlity.Download($"{libraryLocation}{libraryRoot}/{file}", bucketName, $"{libraryRoot}/{file}");
                downloadProgress.Increment(1);
                int fileIndex = syncPanel.downloadCheckListBox.Items.IndexOf(file);
                syncPanel.downloadCheckListBox.Items.Remove(file);
            }
        }

        private void StartUploadClick(object sender, EventArgs e)
        {
            syncPanel.uploadTableLayout.Controls.Remove(syncPanel.startUploadButton);
            string dataPath = $"{mbApiInterface.Setting_GetPersistentStoragePath()}{configFile}";
            string[] settings = File.ReadAllLines(dataPath);
            string bucketName = utils.GetIniValue(settings[1]);
            string libraryRoot = utils.GetIniValue(settings[2]);

            NewProgressBar uploadProgress = new NewProgressBar();
            uploadProgress.Maximum = syncPanel.uploadCheckListBox.CheckedItems.Count;
            uploadProgress.Dock = DockStyle.Fill;
            uploadProgress.ForeColor = System.Drawing.Color.FromArgb(mbApiInterface.Setting_GetSkinElementColour(SkinElement.SkinInputPanel, ElementState.ElementStateDefault, ElementComponent.ComponentForeground));
            syncPanel.uploadTableLayout.Controls.Add(uploadProgress, 0, 2);

            TransferUtility transferUitlity = new TransferUtility(client);
            object[] filesToUpload = new object[syncPanel.uploadCheckListBox.CheckedItems.Count];
            syncPanel.uploadCheckListBox.CheckedItems.CopyTo(filesToUpload, 0);

            foreach (var file in filesToUpload)
            {
                if (File.Exists($"{libraryLocation}{libraryRoot}/{file}"))
                {
                    syncPanel.logsLabel.Text = $"Uploading {file}";
                    transferUitlity.Upload($"{libraryLocation}{libraryRoot}/{file}", bucketName, $"{libraryRoot}/{file}");
                    uploadProgress.Increment(1);
                    int fileIndex = syncPanel.uploadCheckListBox.Items.IndexOf(file);
                    syncPanel.uploadCheckListBox.Items.Remove(file);
                }
            }
        }

        private void UnCheckAllButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name.Equals("unCheckAllUploadButton"))
            {
                int totalItems = syncPanel.uploadCheckListBox.Items.Count;

                for (int i = 0; i < totalItems; i++)
                {
                    syncPanel.uploadCheckListBox.SetItemChecked(i, false);
                }
            }
            else
            {
                int totalItems = syncPanel.downloadCheckListBox.Items.Count;

                for (int i = 0; i < totalItems; i++)
                {
                    syncPanel.downloadCheckListBox.SetItemChecked(i, false);
                }
            }
        }

        private void CheckAllButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name.Equals("checkAllUploadButton"))
            {
                int totalItems = syncPanel.uploadCheckListBox.Items.Count;

                for (int i = 0; i < totalItems; i++)
                {
                    syncPanel.uploadCheckListBox.SetItemChecked(i, true);
                }
            }
            else
            {
                int totalItems = syncPanel.downloadCheckListBox.Items.Count;

                for (int i = 0; i < totalItems; i++)
                {
                    syncPanel.downloadCheckListBox.SetItemChecked(i, true);
                }
            }
        }

        private void CheckListBoxItemChecked(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;
            int totalChecked = checkedListBox.CheckedItems.Count;
            if (totalChecked > 0 || e.NewValue == CheckState.Checked)
            {
                if (checkedListBox.Name.Equals("uploadCheckListBox"))
                {
                    syncPanel.startUploadButton.Enabled = true;
                }
                else
                {
                    syncPanel.startDownloadButton.Enabled = true;
                }
            }
            if (totalChecked == 1 && e.NewValue == CheckState.Unchecked)
            {
                if (checkedListBox.Name.Equals("uploadCheckListBox"))
                {
                    syncPanel.startUploadButton.Enabled = false;
                }
                else
                {
                    syncPanel.startDownloadButton.Enabled = false;
                }
            }
        }
    }
}