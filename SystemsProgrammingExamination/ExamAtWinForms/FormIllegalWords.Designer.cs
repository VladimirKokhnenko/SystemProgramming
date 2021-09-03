namespace ExamAtWinForms
{
    partial class FormIllegalWords
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
            this.listBoxIllegalWords = new System.Windows.Forms.ListBox();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.textBoxAddFile = new System.Windows.Forms.TextBox();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.textBoxAddWord = new System.Windows.Forms.TextBox();
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.textBoxEditWord = new System.Windows.Forms.TextBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDelList = new System.Windows.Forms.Button();
            this.buttonDelWord = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxIllegalWords
            // 
            this.listBoxIllegalWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxIllegalWords.FormattingEnabled = true;
            this.listBoxIllegalWords.Location = new System.Drawing.Point(12, 12);
            this.listBoxIllegalWords.Name = "listBoxIllegalWords";
            this.listBoxIllegalWords.Size = new System.Drawing.Size(372, 615);
            this.listBoxIllegalWords.TabIndex = 0;
            this.listBoxIllegalWords.Click += new System.EventHandler(this.ListBoxIllegalWords_Click);
            this.listBoxIllegalWords.DoubleClick += new System.EventHandler(this.ListBoxIllegalWords_DoubleClick);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.textBoxAddFile);
            this.groupBoxAdd.Controls.Add(this.buttonAddFile);
            this.groupBoxAdd.Controls.Add(this.textBoxAddWord);
            this.groupBoxAdd.Controls.Add(this.buttonAddWord);
            this.groupBoxAdd.Location = new System.Drawing.Point(390, 12);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(398, 88);
            this.groupBoxAdd.TabIndex = 1;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавить";
            // 
            // textBoxAddFile
            // 
            this.textBoxAddFile.Location = new System.Drawing.Point(85, 48);
            this.textBoxAddFile.Name = "textBoxAddFile";
            this.textBoxAddFile.Size = new System.Drawing.Size(307, 20);
            this.textBoxAddFile.TabIndex = 3;
            this.textBoxAddFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAddFile_KeyDown);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(7, 48);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(72, 23);
            this.buttonAddFile.TabIndex = 2;
            this.buttonAddFile.Text = "Файл";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.ButtonAddFile_Click);
            // 
            // textBoxAddWord
            // 
            this.textBoxAddWord.Location = new System.Drawing.Point(85, 21);
            this.textBoxAddWord.Name = "textBoxAddWord";
            this.textBoxAddWord.Size = new System.Drawing.Size(307, 20);
            this.textBoxAddWord.TabIndex = 1;
            this.textBoxAddWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAddWord_KeyDown);
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.Location = new System.Drawing.Point(6, 19);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(73, 23);
            this.buttonAddWord.TabIndex = 0;
            this.buttonAddWord.Text = "Слово";
            this.buttonAddWord.UseVisualStyleBackColor = true;
            this.buttonAddWord.Click += new System.EventHandler(this.ButtonAddWord_Click);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.textBoxEditWord);
            this.groupBoxEdit.Location = new System.Drawing.Point(390, 199);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(398, 58);
            this.groupBoxEdit.TabIndex = 3;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Редактировать";
            // 
            // textBoxEditWord
            // 
            this.textBoxEditWord.Enabled = false;
            this.textBoxEditWord.Location = new System.Drawing.Point(7, 20);
            this.textBoxEditWord.Name = "textBoxEditWord";
            this.textBoxEditWord.Size = new System.Drawing.Size(385, 20);
            this.textBoxEditWord.TabIndex = 3;
            this.textBoxEditWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEditWord_KeyDown);
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.buttonDelList);
            this.groupBoxDelete.Controls.Add(this.buttonDelWord);
            this.groupBoxDelete.Location = new System.Drawing.Point(390, 106);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(120, 79);
            this.groupBoxDelete.TabIndex = 4;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Удалить";
            // 
            // buttonDelList
            // 
            this.buttonDelList.Enabled = false;
            this.buttonDelList.Location = new System.Drawing.Point(6, 45);
            this.buttonDelList.Name = "buttonDelList";
            this.buttonDelList.Size = new System.Drawing.Size(108, 23);
            this.buttonDelList.TabIndex = 8;
            this.buttonDelList.Text = "Список";
            this.buttonDelList.UseVisualStyleBackColor = true;
            this.buttonDelList.Click += new System.EventHandler(this.ButtonDelList_Click);
            // 
            // buttonDelWord
            // 
            this.buttonDelWord.Enabled = false;
            this.buttonDelWord.Location = new System.Drawing.Point(6, 16);
            this.buttonDelWord.Name = "buttonDelWord";
            this.buttonDelWord.Size = new System.Drawing.Size(108, 23);
            this.buttonDelWord.TabIndex = 0;
            this.buttonDelWord.Text = "Слово";
            this.buttonDelWord.UseVisualStyleBackColor = true;
            this.buttonDelWord.Click += new System.EventHandler(this.ButtonDelWord_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(713, 604);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // FormIllegalWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.listBoxIllegalWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIllegalWords";
            this.Text = "Список запрещенных слов";
            this.Load += new System.EventHandler(this.FormIllegalWords_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIllegalWords;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.TextBox textBoxAddWord;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.TextBox textBoxAddFile;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.TextBox textBoxEditWord;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonDelWord;
        private System.Windows.Forms.Button buttonDelList;
        private System.Windows.Forms.Button buttonClose;
    }
}