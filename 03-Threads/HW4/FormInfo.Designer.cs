namespace HW4
{
    partial class FormInfo
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
            this.LabelNameCounter = new System.Windows.Forms.Label();
            this.LabelCountFiles = new System.Windows.Forms.Label();
            this.LabelNameScope = new System.Windows.Forms.Label();
            this.LabelScopeFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelNameCounter
            // 
            this.LabelNameCounter.AutoSize = true;
            this.LabelNameCounter.Location = new System.Drawing.Point(12, 9);
            this.LabelNameCounter.Name = "LabelNameCounter";
            this.LabelNameCounter.Size = new System.Drawing.Size(105, 13);
            this.LabelNameCounter.TabIndex = 0;
            this.LabelNameCounter.Text = "Количество вайлов";
            // 
            // LabelCountFiles
            // 
            this.LabelCountFiles.AutoSize = true;
            this.LabelCountFiles.Location = new System.Drawing.Point(199, 9);
            this.LabelCountFiles.Name = "LabelCountFiles";
            this.LabelCountFiles.Size = new System.Drawing.Size(13, 13);
            this.LabelCountFiles.TabIndex = 1;
            this.LabelCountFiles.Text = "0";
            // 
            // LabelNameScope
            // 
            this.LabelNameScope.AutoSize = true;
            this.LabelNameScope.Location = new System.Drawing.Point(12, 36);
            this.LabelNameScope.Name = "LabelNameScope";
            this.LabelNameScope.Size = new System.Drawing.Size(138, 13);
            this.LabelNameScope.TabIndex = 2;
            this.LabelNameScope.Text = "Объем всех файлов, байт";
            // 
            // LabelScopeFiles
            // 
            this.LabelScopeFiles.AutoSize = true;
            this.LabelScopeFiles.Location = new System.Drawing.Point(199, 36);
            this.LabelScopeFiles.Name = "LabelScopeFiles";
            this.LabelScopeFiles.Size = new System.Drawing.Size(13, 13);
            this.LabelScopeFiles.TabIndex = 3;
            this.LabelScopeFiles.Text = "0";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 62);
            this.Controls.Add(this.LabelScopeFiles);
            this.Controls.Add(this.LabelNameScope);
            this.Controls.Add(this.LabelCountFiles);
            this.Controls.Add(this.LabelNameCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormInfo";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }






        #endregion

        private System.Windows.Forms.Label LabelNameCounter;
        private System.Windows.Forms.Label LabelCountFiles;
        private System.Windows.Forms.Label LabelNameScope;
        private System.Windows.Forms.Label LabelScopeFiles;
    }
}