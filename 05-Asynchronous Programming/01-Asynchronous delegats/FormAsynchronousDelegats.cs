using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _01_Asynchronous_delegats
{
    delegate void DelegateCopyFile(byte[] array, string fileName);

    public partial class FormAsynchronousDelegats : Form
    {
        private const int blockForCopy = 4096;
        private readonly DelegateCopyFile handler;

        public FormAsynchronousDelegats()
        {
            InitializeComponent();
            handler = new DelegateCopyFile(CopyFile);
        }

        private void ButtonFromWhere_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            var openFileDialog = new OpenFileDialog
            {
                Filter = "All files(*.*)|*.*",
                Title = "Выберите файл для копирования",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBoxFromWhere.Text = openFileDialog.FileName;
        }

        private void ButtonWhere_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            var folderBrowserDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxWhere.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxWhere.Text) && File.Exists(textBoxFromWhere.Text))
            {
                byte[] array;
                progressBar.Value = 0;

                using (FileStream fstream = File.OpenRead(textBoxFromWhere.Text))
                {
                    array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                }

                string fileName = textBoxWhere.Text + "\\" + Path.GetFileName(textBoxFromWhere.Text);

                if (array.Length - 1 < blockForCopy)
                {
                    progressBar.Maximum = 1;
                    progressBar.Step = 1;
                }
                else
                {
                    progressBar.Maximum = array.Length - 1;
                    progressBar.Step = blockForCopy;
                }


                if (File.Exists(fileName))
                {
                    if (DialogResult.OK == MessageBox.Show("Такой файл уже существует, перезаписать?", "", MessageBoxButtons.OKCancel))
                    {
                        handler.BeginInvoke(array, fileName, new AsyncCallback(AsyncCompleted), null);
                    }
                }
                else
                {
                    handler.BeginInvoke(array, fileName, new AsyncCallback(AsyncCompleted), null);
                }
            }

            if (!Directory.Exists(textBoxWhere.Text))
            {
                MessageBox.Show("Вы указали некорректный путь к каталогу");
            }
            if (!File.Exists(textBoxFromWhere.Text))
            {
                MessageBox.Show("Указан неверный путь к файлу");
            }
        }

        private void CopyFile(byte[] array, string fileName)
        {
            try
            {
                using (FileStream fstream = File.Create(fileName))
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        fstream.WriteByte(array[i]);
                        if (i != 0 && i % blockForCopy == 0)
                        {
                            progressBar.PerformStep();
                        }
                        else if (array.Length - 1 < blockForCopy && i == array.Length - 1)
                        {
                            progressBar.PerformStep();
                        }
                        else if (i == array.Length - 1)
                        {
                            progressBar.PerformStep();
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AsyncCompleted(IAsyncResult asyncResult)
        {
            MessageBox.Show("Копирование завершено, асинхронный делегат завершил свою работу");
            progressBar.Value = 0;
        }
    }
}