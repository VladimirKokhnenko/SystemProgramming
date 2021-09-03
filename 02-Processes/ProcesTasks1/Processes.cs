using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcesTasks
{
    public partial class ProcessesForm : Form
    {
        public ProcessesForm()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "EXE-файл(*.exe)|*.exe|All files(*.*)|*.*",
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