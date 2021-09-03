namespace ExamAtWinForms
{
    partial class FormMainProject
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSaveReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripIllegalWords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPathForSaveAllFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPathText = new System.Windows.Forms.ToolStripTextBox();
            this.FBrDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.listViewFile = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountReplacements = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTopWords = new System.Windows.Forms.ListView();
            this.Word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountHits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripManagement,
            this.toolStripSettings});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripManagement
            // 
            this.toolStripManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStart,
            this.toolStripSeparator1,
            this.toolStripSaveReport});
            this.toolStripManagement.Name = "toolStripManagement";
            this.toolStripManagement.Size = new System.Drawing.Size(85, 20);
            this.toolStripManagement.Text = "Управление";
            // 
            // toolStripStart
            // 
            this.toolStripStart.Name = "toolStripStart";
            this.toolStripStart.Size = new System.Drawing.Size(166, 22);
            this.toolStripStart.Text = "Старт";
            this.toolStripStart.Click += new System.EventHandler(this.ToolStripStart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripSaveReport
            // 
            this.toolStripSaveReport.Name = "toolStripSaveReport";
            this.toolStripSaveReport.Size = new System.Drawing.Size(166, 22);
            this.toolStripSaveReport.Text = "Сохранить отчет";
            this.toolStripSaveReport.Click += new System.EventHandler(this.ToolStripSaveReport_ClickAsync);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripIllegalWords,
            this.toolStripMenuItem1,
            this.toolStripPathForSaveAllFiles});
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(79, 20);
            this.toolStripSettings.Text = "Настройки";
            // 
            // toolStripIllegalWords
            // 
            this.toolStripIllegalWords.Name = "toolStripIllegalWords";
            this.toolStripIllegalWords.Size = new System.Drawing.Size(188, 22);
            this.toolStripIllegalWords.Text = "Запрещенные слова";
            this.toolStripIllegalWords.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // toolStripPathForSaveAllFiles
            // 
            this.toolStripPathForSaveAllFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPathText});
            this.toolStripPathForSaveAllFiles.Name = "toolStripPathForSaveAllFiles";
            this.toolStripPathForSaveAllFiles.Size = new System.Drawing.Size(188, 22);
            this.toolStripPathForSaveAllFiles.Text = "Путь отчета";
            this.toolStripPathForSaveAllFiles.Click += new System.EventHandler(this.FilePathToolStripMenuItem_Click);
            // 
            // toolStripPathText
            // 
            this.toolStripPathText.Enabled = false;
            this.toolStripPathText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripPathText.Name = "toolStripPathText";
            this.toolStripPathText.Size = new System.Drawing.Size(150, 23);
            this.toolStripPathText.Text = "%UserProfile%\\Поиск файлов";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 27);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.listViewFile);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.listViewTopWords);
            this.splitContainerMain.Size = new System.Drawing.Size(800, 531);
            this.splitContainerMain.SplitterDistance = 634;
            this.splitContainerMain.TabIndex = 3;
            // 
            // listViewFile
            // 
            this.listViewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Path,
            this.FileSize,
            this.CountReplacements});
            this.listViewFile.HideSelection = false;
            this.listViewFile.Location = new System.Drawing.Point(-2, -2);
            this.listViewFile.Name = "listViewFile";
            this.listViewFile.Size = new System.Drawing.Size(641, 531);
            this.listViewFile.TabIndex = 0;
            this.listViewFile.UseCompatibleStateImageBehavior = false;
            this.listViewFile.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "Файл";
            this.FileName.Width = 109;
            // 
            // Path
            // 
            this.Path.Text = "Путь";
            this.Path.Width = 345;
            // 
            // FileSize
            // 
            this.FileSize.Text = "Размер";
            this.FileSize.Width = 73;
            // 
            // CountReplacements
            // 
            this.CountReplacements.Text = "Количество замен";
            this.CountReplacements.Width = 106;
            // 
            // listViewTopWords
            // 
            this.listViewTopWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTopWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.CountHits});
            this.listViewTopWords.HideSelection = false;
            this.listViewTopWords.Location = new System.Drawing.Point(3, -2);
            this.listViewTopWords.Name = "listViewTopWords";
            this.listViewTopWords.Size = new System.Drawing.Size(155, 531);
            this.listViewTopWords.TabIndex = 0;
            this.listViewTopWords.UseCompatibleStateImageBehavior = false;
            this.listViewTopWords.View = System.Windows.Forms.View.Details;
            // 
            // Word
            // 
            this.Word.Text = "Слово";
            this.Word.Width = 79;
            // 
            // CountHits
            // 
            this.CountHits.Text = "Количество";
            this.CountHits.Width = 73;
            // 
            // FormMainProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMainProject";
            this.Text = "Поиск запрещенных слов";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripIllegalWords;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripPathForSaveAllFiles;
        private System.Windows.Forms.FolderBrowserDialog FBrDialog;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ListView listViewFile;
        private System.Windows.Forms.ListView listViewTopWords;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ColumnHeader FileSize;
        private System.Windows.Forms.ColumnHeader CountReplacements;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader CountHits;
        private System.Windows.Forms.ToolStripMenuItem toolStripManagement;
        private System.Windows.Forms.ToolStripMenuItem toolStripStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSaveReport;
        private System.Windows.Forms.ToolStripTextBox toolStripPathText;
    }
}

