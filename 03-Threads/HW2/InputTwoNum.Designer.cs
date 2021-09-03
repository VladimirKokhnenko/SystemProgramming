namespace HW2
{
    partial class InputTwoNum
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
            this.InputOne = new System.Windows.Forms.MaskedTextBox();
            this.InputTwo = new System.Windows.Forms.MaskedTextBox();
            this.OutOne = new System.Windows.Forms.Label();
            this.OutTwo = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputOne
            // 
            this.InputOne.Location = new System.Drawing.Point(10, 13);
            this.InputOne.Mask = "0000";
            this.InputOne.Name = "InputOne";
            this.InputOne.Size = new System.Drawing.Size(30, 20);
            this.InputOne.TabIndex = 0;
            this.InputOne.TextChanged += new System.EventHandler(this.InputOne_TextChanged);
            // 
            // InputTwo
            // 
            this.InputTwo.Location = new System.Drawing.Point(10, 39);
            this.InputTwo.Mask = "0000";
            this.InputTwo.Name = "InputTwo";
            this.InputTwo.Size = new System.Drawing.Size(30, 20);
            this.InputTwo.TabIndex = 1;
            this.InputTwo.TextChanged += new System.EventHandler(this.InputTwo_TextChanged);
            // 
            // OutOne
            // 
            this.OutOne.AutoSize = true;
            this.OutOne.Location = new System.Drawing.Point(72, 17);
            this.OutOne.Name = "OutOne";
            this.OutOne.Size = new System.Drawing.Size(13, 13);
            this.OutOne.TabIndex = 2;
            this.OutOne.Text = "0";
            // 
            // OutTwo
            // 
            this.OutTwo.AutoSize = true;
            this.OutTwo.Location = new System.Drawing.Point(72, 42);
            this.OutTwo.Name = "OutTwo";
            this.OutTwo.Size = new System.Drawing.Size(13, 13);
            this.OutTwo.TabIndex = 3;
            this.OutTwo.Text = "0";
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(10, 75);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "&Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(91, 76);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "S&top";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(172, 76);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // InputTwoNum
            // 
            this.AcceptButton = this.Start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(256, 109);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.OutTwo);
            this.Controls.Add(this.OutOne);
            this.Controls.Add(this.InputTwo);
            this.Controls.Add(this.InputOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "InputTwoNum";
            this.Text = "FormTwoNum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox InputOne;
        private System.Windows.Forms.MaskedTextBox InputTwo;
        private System.Windows.Forms.Label OutOne;
        private System.Windows.Forms.Label OutTwo;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Cancel;
    }
}

