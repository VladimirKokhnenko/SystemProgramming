using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProcesTasks2
{
    public partial class Processes : Form
    {
        public Processes()
        {
            InitializeComponent();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовый файл(*.txt)|*.txt|All files(*.*)|*.*",
                Title = "Выберите файл для запуска",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Process.Start(openFileDialog.FileName);
            }
        }
    }
}