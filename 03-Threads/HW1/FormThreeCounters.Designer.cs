namespace HW1
{
    partial class FormThreeCounters
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
            this.LabelNameOne = new System.Windows.Forms.Label();
            this.LabelNameTwo = new System.Windows.Forms.Label();
            this.LabelNameThree = new System.Windows.Forms.Label();
            this.LabelCounterOne = new System.Windows.Forms.Label();
            this.LabelCounterTwo = new System.Windows.Forms.Label();
            this.LabelCounterThree = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNameOne
            // 
            this.LabelNameOne.AutoSize = true;
            this.LabelNameOne.Location = new System.Drawing.Point(23, 18);
            this.LabelNameOne.Name = "LabelNameOne";
            this.LabelNameOne.Size = new System.Drawing.Size(43, 13);
            this.LabelNameOne.TabIndex = 0;
            this.LabelNameOne.Text = "0.5 сек";
            // 
            // LabelNameTwo
            // 
            this.LabelNameTwo.AutoSize = true;
            this.LabelNameTwo.Location = new System.Drawing.Point(23, 49);
            this.LabelNameTwo.Name = "LabelNameTwo";
            this.LabelNameTwo.Size = new System.Drawing.Size(43, 13);
            this.LabelNameTwo.TabIndex = 1;
            this.LabelNameTwo.Text = "1.0 сек";
            // 
            // LabelNameThree
            // 
            this.LabelNameThree.AutoSize = true;
            this.LabelNameThree.Location = new System.Drawing.Point(23, 81);
            this.LabelNameThree.Name = "LabelNameThree";
            this.LabelNameThree.Size = new System.Drawing.Size(43, 13);
            this.LabelNameThree.TabIndex = 2;
            this.LabelNameThree.Text = "1.5 сек";
            // 
            // LabelCounterOne
            // 
            this.LabelCounterOne.AutoSize = true;
            this.LabelCounterOne.Location = new System.Drawing.Point(83, 18);
            this.LabelCounterOne.Name = "LabelCounterOne";
            this.LabelCounterOne.Size = new System.Drawing.Size(13, 13);
            this.LabelCounterOne.TabIndex = 3;
            this.LabelCounterOne.Text = "0";
            // 
            // LabelCounterTwo
            // 
            this.LabelCounterTwo.AutoSize = true;
            this.LabelCounterTwo.Location = new System.Drawing.Point(83, 49);
            this.LabelCounterTwo.Name = "LabelCounterTwo";
            this.LabelCounterTwo.Size = new System.Drawing.Size(13, 13);
            this.LabelCounterTwo.TabIndex = 4;
            this.LabelCounterTwo.Text = "0";
            // 
            // LabelCounterThree
            // 
            this.LabelCounterThree.AutoSize = true;
            this.LabelCounterThree.Location = new System.Drawing.Point(83, 81);
            this.LabelCounterThree.Name = "LabelCounterThree";
            this.LabelCounterThree.Size = new System.Drawing.Size(13, 13);
            this.LabelCounterThree.TabIndex = 5;
            this.LabelCounterThree.Text = "0";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(44, 128);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 6;
            this.Start.Text = "&Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Reset
            // 
            this.Reset.Enabled = false;
            this.Reset.Location = new System.Drawing.Point(125, 128);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "&Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(206, 128);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 8;
            this.Stop.Text = "S&top";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(125, 172);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FormThreeCounters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 207);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.LabelCounterThree);
            this.Controls.Add(this.LabelCounterTwo);
            this.Controls.Add(this.LabelCounterOne);
            this.Controls.Add(this.LabelNameThree);
            this.Controls.Add(this.LabelNameTwo);
            this.Controls.Add(this.LabelNameOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormThreeCounters";
            this.Text = "ThreeCounters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNameOne;
        private System.Windows.Forms.Label LabelNameTwo;
        private System.Windows.Forms.Label LabelNameThree;
        private System.Windows.Forms.Label LabelCounterOne;
        private System.Windows.Forms.Label LabelCounterTwo;
        private System.Windows.Forms.Label LabelCounterThree;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Cancel;
    }
}

