namespace _02_Async_Await
{
    partial class AsyncAwait
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
            this.labelFromWhere = new System.Windows.Forms.Label();
            this.labelWhere = new System.Windows.Forms.Label();
            this.textBoxFromWhere = new System.Windows.Forms.TextBox();
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.buttonFromWhere = new System.Windows.Forms.Button();
            this.buttonWhere = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelForCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFromWhere
            // 
            this.labelFromWhere.AutoSize = true;
            this.labelFromWhere.Location = new System.Drawing.Point(13, 13);
            this.labelFromWhere.Name = "labelFromWhere";
            this.labelFromWhere.Size = new System.Drawing.Size(46, 13);
            this.labelFromWhere.TabIndex = 0;
            this.labelFromWhere.Text = "От куда";
            // 
            // labelWhere
            // 
            this.labelWhere.AutoSize = true;
            this.labelWhere.Location = new System.Drawing.Point(13, 47);
            this.labelWhere.Name = "labelWhere";
            this.labelWhere.Size = new System.Drawing.Size(31, 13);
            this.labelWhere.TabIndex = 1;
            this.labelWhere.Text = "Куда";
            // 
            // textBoxFromWhere
            // 
            this.textBoxFromWhere.Location = new System.Drawing.Point(65, 10);
            this.textBoxFromWhere.Name = "textBoxFromWhere";
            this.textBoxFromWhere.Size = new System.Drawing.Size(581, 20);
            this.textBoxFromWhere.TabIndex = 2;
            this.textBoxFromWhere.Text = "C:\\Users\\vanko\\Desktop\\TimeCalculator\\TimeCalculator.sln";
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Location = new System.Drawing.Point(65, 44);
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(581, 20);
            this.textBoxWhere.TabIndex = 3;
            this.textBoxWhere.Text = "D:\\Новая папка";
            // 
            // buttonFromWhere
            // 
            this.buttonFromWhere.Location = new System.Drawing.Point(667, 8);
            this.buttonFromWhere.Name = "buttonFromWhere";
            this.buttonFromWhere.Size = new System.Drawing.Size(75, 23);
            this.buttonFromWhere.TabIndex = 4;
            this.buttonFromWhere.Text = "Файл";
            this.buttonFromWhere.UseVisualStyleBackColor = true;
            this.buttonFromWhere.Click += new System.EventHandler(this.ButtonFromWhere_Click);
            // 
            // buttonWhere
            // 
            this.buttonWhere.Location = new System.Drawing.Point(667, 42);
            this.buttonWhere.Name = "buttonWhere";
            this.buttonWhere.Size = new System.Drawing.Size(75, 23);
            this.buttonWhere.TabIndex = 5;
            this.buttonWhere.Text = "Файл";
            this.buttonWhere.UseVisualStyleBackColor = true;
            this.buttonWhere.Click += new System.EventHandler(this.ButtonWhere_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 100);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(630, 23);
            this.progressBar.TabIndex = 6;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(667, 100);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // labelForCopy
            // 
            this.labelForCopy.AutoSize = true;
            this.labelForCopy.Location = new System.Drawing.Point(65, 77);
            this.labelForCopy.Name = "labelForCopy";
            this.labelForCopy.Size = new System.Drawing.Size(110, 13);
            this.labelForCopy.TabIndex = 8;
            this.labelForCopy.Text = "Статус копирования";
            // 
            // AsyncAwait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 149);
            this.Controls.Add(this.labelForCopy);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonWhere);
            this.Controls.Add(this.buttonFromWhere);
            this.Controls.Add(this.textBoxWhere);
            this.Controls.Add(this.textBoxFromWhere);
            this.Controls.Add(this.labelWhere);
            this.Controls.Add(this.labelFromWhere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AsyncAwait";
            this.Text = "AsynchronousDelegats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFromWhere;
        private System.Windows.Forms.Label labelWhere;
        private System.Windows.Forms.TextBox textBoxFromWhere;
        private System.Windows.Forms.TextBox textBoxWhere;
        private System.Windows.Forms.Button buttonFromWhere;
        private System.Windows.Forms.Button buttonWhere;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelForCopy;
    }
}

