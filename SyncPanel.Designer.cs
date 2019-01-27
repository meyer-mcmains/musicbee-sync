namespace MusicBeePlugin
{
    partial class SyncPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bucketNameLabel = new System.Windows.Forms.Label();
            this.bucketRegionLabel = new System.Windows.Forms.Label();
            this.libraryRootLabel = new System.Windows.Forms.Label();
            this.startSyncButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.totalFilesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uploadGroup = new System.Windows.Forms.GroupBox();
            this.uploadTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.startUploadButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.totalToUploadLabel = new System.Windows.Forms.Label();
            this.unCheckAllUploadButton = new System.Windows.Forms.Button();
            this.checkAllUploadButton = new System.Windows.Forms.Button();
            this.uploadCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.downloadGroup = new System.Windows.Forms.GroupBox();
            this.downloadTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.totalToDownloadLabel = new System.Windows.Forms.Label();
            this.unCheckAllDownloadButton = new System.Windows.Forms.Button();
            this.checkAllDownloadButton = new System.Windows.Forms.Button();
            this.syncProgressBar = new NewProgressBar();
            this.logsLabel = new System.Windows.Forms.Label();
            this.startDownloadButton = new System.Windows.Forms.Button();
            this.downloadCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.uploadGroup.SuspendLayout();
            this.uploadTableLayout.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.downloadGroup.SuspendLayout();
            this.downloadTableLayout.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.syncProgressBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.logsLabel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 653);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Controls.Add(this.bucketNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bucketRegionLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.libraryRootLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.startSyncButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.closeButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalFilesLabel, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(961, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // bucketNameLabel
            // 
            this.bucketNameLabel.AutoSize = true;
            this.bucketNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bucketNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bucketNameLabel.Location = new System.Drawing.Point(317, 3);
            this.bucketNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.bucketNameLabel.Name = "bucketNameLabel";
            this.bucketNameLabel.Size = new System.Drawing.Size(197, 29);
            this.bucketNameLabel.TabIndex = 6;
            this.bucketNameLabel.Text = "Bucket Name:";
            this.bucketNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bucketRegionLabel
            // 
            this.bucketRegionLabel.AutoSize = true;
            this.bucketRegionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bucketRegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bucketRegionLabel.Location = new System.Drawing.Point(114, 3);
            this.bucketRegionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.bucketRegionLabel.Name = "bucketRegionLabel";
            this.bucketRegionLabel.Size = new System.Drawing.Size(197, 29);
            this.bucketRegionLabel.TabIndex = 5;
            this.bucketRegionLabel.Text = "Bucket Region:";
            this.bucketRegionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // libraryRootLabel
            // 
            this.libraryRootLabel.AutoSize = true;
            this.libraryRootLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryRootLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryRootLabel.Location = new System.Drawing.Point(520, 3);
            this.libraryRootLabel.Margin = new System.Windows.Forms.Padding(3);
            this.libraryRootLabel.Name = "libraryRootLabel";
            this.libraryRootLabel.Size = new System.Drawing.Size(197, 29);
            this.libraryRootLabel.TabIndex = 4;
            this.libraryRootLabel.Text = "Library Root:";
            this.libraryRootLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startSyncButton
            // 
            this.startSyncButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startSyncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSyncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSyncButton.Location = new System.Drawing.Point(3, 3);
            this.startSyncButton.Name = "startSyncButton";
            this.startSyncButton.Size = new System.Drawing.Size(105, 29);
            this.startSyncButton.TabIndex = 1;
            this.startSyncButton.Text = "Start Scan";
            this.startSyncButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(926, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 29);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // totalFilesLabel
            // 
            this.totalFilesLabel.AutoSize = true;
            this.totalFilesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFilesLabel.Location = new System.Drawing.Point(723, 3);
            this.totalFilesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.totalFilesLabel.Name = "totalFilesLabel";
            this.totalFilesLabel.Size = new System.Drawing.Size(197, 29);
            this.totalFilesLabel.TabIndex = 7;
            this.totalFilesLabel.Text = "Total Files:";
            this.totalFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.uploadGroup, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.downloadGroup, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(961, 557);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // uploadGroup
            // 
            this.uploadGroup.Controls.Add(this.uploadTableLayout);
            this.uploadGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadGroup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uploadGroup.Location = new System.Drawing.Point(490, 3);
            this.uploadGroup.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.uploadGroup.Name = "uploadGroup";
            this.uploadGroup.Size = new System.Drawing.Size(468, 551);
            this.uploadGroup.TabIndex = 2;
            this.uploadGroup.TabStop = false;
            this.uploadGroup.Text = "Files To Upload";
            // 
            // uploadTableLayout
            // 
            this.uploadTableLayout.ColumnCount = 1;
            this.uploadTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uploadTableLayout.Controls.Add(this.startUploadButton, 0, 2);
            this.uploadTableLayout.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.uploadTableLayout.Controls.Add(this.uploadCheckListBox, 0, 1);
            this.uploadTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadTableLayout.Location = new System.Drawing.Point(3, 25);
            this.uploadTableLayout.Name = "uploadTableLayout";
            this.uploadTableLayout.RowCount = 3;
            this.uploadTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.uploadTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uploadTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.uploadTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uploadTableLayout.Size = new System.Drawing.Size(462, 523);
            this.uploadTableLayout.TabIndex = 0;
            // 
            // startUploadButton
            // 
            this.startUploadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startUploadButton.Enabled = false;
            this.startUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startUploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startUploadButton.Location = new System.Drawing.Point(3, 491);
            this.startUploadButton.Name = "startUploadButton";
            this.startUploadButton.Size = new System.Drawing.Size(456, 29);
            this.startUploadButton.TabIndex = 6;
            this.startUploadButton.Text = "Start Upload";
            this.startUploadButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.totalToUploadLabel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.unCheckAllUploadButton, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.checkAllUploadButton, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(456, 29);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // totalToUploadLabel
            // 
            this.totalToUploadLabel.AutoSize = true;
            this.totalToUploadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalToUploadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalToUploadLabel.Location = new System.Drawing.Point(231, 3);
            this.totalToUploadLabel.Margin = new System.Windows.Forms.Padding(3);
            this.totalToUploadLabel.Name = "totalToUploadLabel";
            this.totalToUploadLabel.Size = new System.Drawing.Size(222, 23);
            this.totalToUploadLabel.TabIndex = 8;
            this.totalToUploadLabel.Text = "Total Files:";
            this.totalToUploadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unCheckAllUploadButton
            // 
            this.unCheckAllUploadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unCheckAllUploadButton.Enabled = false;
            this.unCheckAllUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unCheckAllUploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unCheckAllUploadButton.Location = new System.Drawing.Point(117, 3);
            this.unCheckAllUploadButton.Name = "unCheckAllUploadButton";
            this.unCheckAllUploadButton.Size = new System.Drawing.Size(108, 23);
            this.unCheckAllUploadButton.TabIndex = 7;
            this.unCheckAllUploadButton.Text = "Un-Check All";
            this.unCheckAllUploadButton.UseVisualStyleBackColor = true;
            // 
            // checkAllUploadButton
            // 
            this.checkAllUploadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkAllUploadButton.Enabled = false;
            this.checkAllUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAllUploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAllUploadButton.Location = new System.Drawing.Point(3, 3);
            this.checkAllUploadButton.Name = "checkAllUploadButton";
            this.checkAllUploadButton.Size = new System.Drawing.Size(108, 23);
            this.checkAllUploadButton.TabIndex = 6;
            this.checkAllUploadButton.Text = "Check All";
            this.checkAllUploadButton.UseVisualStyleBackColor = true;
            // 
            // uploadCheckListBox
            // 
            this.uploadCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uploadCheckListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadCheckListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadCheckListBox.FormattingEnabled = true;
            this.uploadCheckListBox.Location = new System.Drawing.Point(3, 38);
            this.uploadCheckListBox.Name = "uploadCheckListBox";
            this.uploadCheckListBox.Size = new System.Drawing.Size(456, 447);
            this.uploadCheckListBox.TabIndex = 7;
            // 
            // downloadGroup
            // 
            this.downloadGroup.Controls.Add(this.downloadTableLayout);
            this.downloadGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadGroup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.downloadGroup.Location = new System.Drawing.Point(3, 3);
            this.downloadGroup.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.downloadGroup.Name = "downloadGroup";
            this.downloadGroup.Size = new System.Drawing.Size(467, 551);
            this.downloadGroup.TabIndex = 1;
            this.downloadGroup.TabStop = false;
            this.downloadGroup.Text = "Files To Download";
            // 
            // downloadTableLayout
            // 
            this.downloadTableLayout.ColumnCount = 1;
            this.downloadTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.downloadTableLayout.Controls.Add(this.startDownloadButton, 0, 2);
            this.downloadTableLayout.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.downloadTableLayout.Controls.Add(this.downloadCheckListBox, 0, 1);
            this.downloadTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadTableLayout.Location = new System.Drawing.Point(3, 25);
            this.downloadTableLayout.Name = "downloadTableLayout";
            this.downloadTableLayout.RowCount = 3;
            this.downloadTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.downloadTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.downloadTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.downloadTableLayout.Size = new System.Drawing.Size(461, 523);
            this.downloadTableLayout.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.totalToDownloadLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.unCheckAllDownloadButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.checkAllDownloadButton, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(455, 29);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // totalToDownloadLabel
            // 
            this.totalToDownloadLabel.AutoSize = true;
            this.totalToDownloadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalToDownloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalToDownloadLabel.Location = new System.Drawing.Point(229, 3);
            this.totalToDownloadLabel.Margin = new System.Windows.Forms.Padding(3);
            this.totalToDownloadLabel.Name = "totalToDownloadLabel";
            this.totalToDownloadLabel.Size = new System.Drawing.Size(223, 23);
            this.totalToDownloadLabel.TabIndex = 8;
            this.totalToDownloadLabel.Text = "Total Files:";
            this.totalToDownloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unCheckAllDownloadButton
            // 
            this.unCheckAllDownloadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unCheckAllDownloadButton.Enabled = false;
            this.unCheckAllDownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unCheckAllDownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unCheckAllDownloadButton.Location = new System.Drawing.Point(116, 3);
            this.unCheckAllDownloadButton.Name = "unCheckAllDownloadButton";
            this.unCheckAllDownloadButton.Size = new System.Drawing.Size(107, 23);
            this.unCheckAllDownloadButton.TabIndex = 7;
            this.unCheckAllDownloadButton.Text = "Un-Check All";
            this.unCheckAllDownloadButton.UseVisualStyleBackColor = true;
            // 
            // checkAllDownloadButton
            // 
            this.checkAllDownloadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkAllDownloadButton.Enabled = false;
            this.checkAllDownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAllDownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAllDownloadButton.Location = new System.Drawing.Point(3, 3);
            this.checkAllDownloadButton.Name = "checkAllDownloadButton";
            this.checkAllDownloadButton.Size = new System.Drawing.Size(107, 23);
            this.checkAllDownloadButton.TabIndex = 6;
            this.checkAllDownloadButton.Text = "Check All";
            this.checkAllDownloadButton.UseVisualStyleBackColor = true;
            // 
            // syncProgressBar
            // 
            this.syncProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncProgressBar.Location = new System.Drawing.Point(3, 43);
            this.syncProgressBar.Name = "syncProgressBar";
            this.syncProgressBar.Size = new System.Drawing.Size(961, 19);
            this.syncProgressBar.TabIndex = 3;
            // 
            // logsLabel
            // 
            this.logsLabel.AutoSize = true;
            this.logsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsLabel.Location = new System.Drawing.Point(3, 631);
            this.logsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.logsLabel.Name = "logsLabel";
            this.logsLabel.Size = new System.Drawing.Size(961, 19);
            this.logsLabel.TabIndex = 4;
            this.logsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startDownloadButton
            // 
            this.startDownloadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDownloadButton.Enabled = false;
            this.startDownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDownloadButton.Location = new System.Drawing.Point(3, 491);
            this.startDownloadButton.Name = "startDownloadButton";
            this.startDownloadButton.Size = new System.Drawing.Size(455, 29);
            this.startDownloadButton.TabIndex = 6;
            this.startDownloadButton.Text = "Start Download";
            this.startDownloadButton.UseVisualStyleBackColor = true;
            // 
            // downloadCheckListBox
            // 
            this.downloadCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.downloadCheckListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadCheckListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCheckListBox.FormattingEnabled = true;
            this.downloadCheckListBox.Location = new System.Drawing.Point(3, 38);
            this.downloadCheckListBox.Name = "downloadCheckListBox";
            this.downloadCheckListBox.Size = new System.Drawing.Size(455, 447);
            this.downloadCheckListBox.TabIndex = 7;
            // 
            // SyncPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SyncPanel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(987, 673);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.uploadGroup.ResumeLayout(false);
            this.uploadTableLayout.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.downloadGroup.ResumeLayout(false);
            this.downloadTableLayout.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.GroupBox downloadGroup;
        public System.Windows.Forms.GroupBox uploadGroup;
        public System.Windows.Forms.Button startSyncButton;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label logsLabel;
        public System.Windows.Forms.Label bucketNameLabel;
        public System.Windows.Forms.Label bucketRegionLabel;
        public System.Windows.Forms.Label libraryRootLabel;
        public System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label totalFilesLabel;
        public System.Windows.Forms.Button startUploadButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        public System.Windows.Forms.Label totalToUploadLabel;
        public System.Windows.Forms.Button unCheckAllUploadButton;
        public System.Windows.Forms.Button checkAllUploadButton;
        public System.Windows.Forms.CheckedListBox uploadCheckListBox;
        public NewProgressBar syncProgressBar;
        public System.Windows.Forms.TableLayoutPanel downloadTableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public System.Windows.Forms.Label totalToDownloadLabel;
        public System.Windows.Forms.Button unCheckAllDownloadButton;
        public System.Windows.Forms.Button checkAllDownloadButton;
        public System.Windows.Forms.Button startDownloadButton;
        public System.Windows.Forms.CheckedListBox downloadCheckListBox;
        public System.Windows.Forms.TableLayoutPanel uploadTableLayout;
    }
}
