namespace Semaphores
{
    partial class FormSemaphor
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
            this.LabelOperatingStreams = new System.Windows.Forms.Label();
            this.LabelWaitingStreams = new System.Windows.Forms.Label();
            this.LabelGeneratedStreams = new System.Windows.Forms.Label();
            this.listBoxOperatingStreams = new System.Windows.Forms.ListBox();
            this.listBoxWaitingStreams = new System.Windows.Forms.ListBox();
            this.listBoxGeneratedStreams = new System.Windows.Forms.ListBox();
            this.LabelSemaphoreSeats = new System.Windows.Forms.Label();
            this.NumericInitialCount = new System.Windows.Forms.NumericUpDown();
            this.ButtonCreateStream = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInitialCount)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelOperatingStreams
            // 
            this.LabelOperatingStreams.AutoSize = true;
            this.LabelOperatingStreams.Location = new System.Drawing.Point(21, 13);
            this.LabelOperatingStreams.Name = "LabelOperatingStreams";
            this.LabelOperatingStreams.Size = new System.Drawing.Size(110, 13);
            this.LabelOperatingStreams.TabIndex = 0;
            this.LabelOperatingStreams.Text = "Работающие потоки";
            // 
            // LabelWaitingStreams
            // 
            this.LabelWaitingStreams.AutoSize = true;
            this.LabelWaitingStreams.Location = new System.Drawing.Point(250, 13);
            this.LabelWaitingStreams.Name = "LabelWaitingStreams";
            this.LabelWaitingStreams.Size = new System.Drawing.Size(108, 13);
            this.LabelWaitingStreams.TabIndex = 1;
            this.LabelWaitingStreams.Text = "Ожидающие потоки";
            // 
            // LabelGeneratedStreams
            // 
            this.LabelGeneratedStreams.AutoSize = true;
            this.LabelGeneratedStreams.Location = new System.Drawing.Point(477, 13);
            this.LabelGeneratedStreams.Name = "LabelGeneratedStreams";
            this.LabelGeneratedStreams.Size = new System.Drawing.Size(102, 13);
            this.LabelGeneratedStreams.TabIndex = 2;
            this.LabelGeneratedStreams.Text = "Созданные потоки";
            // 
            // listBoxOperatingStreams
            // 
            this.listBoxOperatingStreams.FormattingEnabled = true;
            this.listBoxOperatingStreams.Location = new System.Drawing.Point(24, 29);
            this.listBoxOperatingStreams.Name = "listBoxOperatingStreams";
            this.listBoxOperatingStreams.Size = new System.Drawing.Size(163, 95);
            this.listBoxOperatingStreams.TabIndex = 3;
            // 
            // listBoxWaitingStreams
            // 
            this.listBoxWaitingStreams.FormattingEnabled = true;
            this.listBoxWaitingStreams.Location = new System.Drawing.Point(253, 29);
            this.listBoxWaitingStreams.Name = "listBoxWaitingStreams";
            this.listBoxWaitingStreams.Size = new System.Drawing.Size(163, 95);
            this.listBoxWaitingStreams.TabIndex = 4;
            // 
            // listBoxGeneratedStreams
            // 
            this.listBoxGeneratedStreams.FormattingEnabled = true;
            this.listBoxGeneratedStreams.Location = new System.Drawing.Point(480, 29);
            this.listBoxGeneratedStreams.Name = "listBoxGeneratedStreams";
            this.listBoxGeneratedStreams.Size = new System.Drawing.Size(163, 95);
            this.listBoxGeneratedStreams.TabIndex = 5;
            this.listBoxGeneratedStreams.DoubleClick += new System.EventHandler(this.ListBoxGeneratedStreams_DoubleClick);
            // 
            // LabelSemaphoreSeats
            // 
            this.LabelSemaphoreSeats.AutoSize = true;
            this.LabelSemaphoreSeats.Location = new System.Drawing.Point(21, 153);
            this.LabelSemaphoreSeats.Name = "LabelSemaphoreSeats";
            this.LabelSemaphoreSeats.Size = new System.Drawing.Size(158, 13);
            this.LabelSemaphoreSeats.TabIndex = 6;
            this.LabelSemaphoreSeats.Text = "Количество мест в семафоре";
            // 
            // NumericInitialCount
            // 
            this.NumericInitialCount.Location = new System.Drawing.Point(24, 169);
            this.NumericInitialCount.Name = "NumericInitialCount";
            this.NumericInitialCount.ReadOnly = true;
            this.NumericInitialCount.Size = new System.Drawing.Size(155, 20);
            this.NumericInitialCount.TabIndex = 7;
            this.NumericInitialCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericInitialCount.ValueChanged += new System.EventHandler(this.NumericInitialCount_ValueChanged);
            // 
            // ButtonCreateStream
            // 
            this.ButtonCreateStream.Location = new System.Drawing.Point(480, 169);
            this.ButtonCreateStream.Name = "ButtonCreateStream";
            this.ButtonCreateStream.Size = new System.Drawing.Size(163, 23);
            this.ButtonCreateStream.TabIndex = 8;
            this.ButtonCreateStream.Text = "Создать поток";
            this.ButtonCreateStream.UseVisualStyleBackColor = true;
            this.ButtonCreateStream.Click += new System.EventHandler(this.ButtonCreateStream_Click);
            // 
            // FormSemaphor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 218);
            this.Controls.Add(this.ButtonCreateStream);
            this.Controls.Add(this.NumericInitialCount);
            this.Controls.Add(this.LabelSemaphoreSeats);
            this.Controls.Add(this.listBoxGeneratedStreams);
            this.Controls.Add(this.listBoxWaitingStreams);
            this.Controls.Add(this.listBoxOperatingStreams);
            this.Controls.Add(this.LabelGeneratedStreams);
            this.Controls.Add(this.LabelWaitingStreams);
            this.Controls.Add(this.LabelOperatingStreams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSemaphor";
            this.Text = "Тест Семафора";
            ((System.ComponentModel.ISupportInitialize)(this.NumericInitialCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelOperatingStreams;
        private System.Windows.Forms.Label LabelWaitingStreams;
        private System.Windows.Forms.Label LabelGeneratedStreams;
        private System.Windows.Forms.ListBox listBoxOperatingStreams;
        private System.Windows.Forms.ListBox listBoxWaitingStreams;
        private System.Windows.Forms.ListBox listBoxGeneratedStreams;
        private System.Windows.Forms.Label LabelSemaphoreSeats;
        private System.Windows.Forms.NumericUpDown NumericInitialCount;
        private System.Windows.Forms.Button ButtonCreateStream;
    }
}

