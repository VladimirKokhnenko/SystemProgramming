namespace HW4
{
    partial class DialogWithCatalog
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
            this.TInputPath = new System.Windows.Forms.TextBox();
            this.BEnter = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TInputPath
            // 
            this.TInputPath.Location = new System.Drawing.Point(12, 9);
            this.TInputPath.Name = "TInputPath";
            this.TInputPath.Size = new System.Drawing.Size(776, 20);
            this.TInputPath.TabIndex = 0;
            this.TInputPath.Text = "Введите путь";
            // 
            // BEnter
            // 
            this.BEnter.Location = new System.Drawing.Point(12, 35);
            this.BEnter.Name = "BEnter";
            this.BEnter.Size = new System.Drawing.Size(75, 23);
            this.BEnter.TabIndex = 1;
            this.BEnter.Text = "&Enter";
            this.BEnter.UseVisualStyleBackColor = true;
            this.BEnter.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(713, 35);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 2;
            this.BCancel.Text = "&Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // DialogWithCatalog
            // 
            this.AcceptButton = this.BEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCancel;
            this.ClientSize = new System.Drawing.Size(800, 67);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BEnter);
            this.Controls.Add(this.TInputPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DialogWithCatalog";
            this.Text = "Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TInputPath;
        private System.Windows.Forms.Button BEnter;
        private System.Windows.Forms.Button BCancel;
    }
}

