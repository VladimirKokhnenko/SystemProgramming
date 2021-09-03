using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Async_Await
{
    public partial class AsyncAwait : Form
    {
        private const int blockForCopy = 4096;

        public AsyncAwait()
        {
            InitializeComponent();
        }

        private void ButtonFromWhere_Click(object sender, EventArgs e)
        {
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
            var folderBrowserDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxWhere.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private async void ButtonCopy_Click(object sender, EventArgs e)
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
                        await CopyFile(array, fileName);
                }
                else
                {
                    await CopyFile(array, fileName);
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

        private Task CopyFile(byte[] array, string fileName)
        {
            return Task.Run(() =>
            {
                try
                {
                    labelForCopy.Text = "Копирование запущено";

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

                        labelForCopy.Text = "Копирование завершено";

                        if (DialogResult.OK == MessageBox.Show("Копирование завершено"))
                        {
                            progressBar.Value = 0;
                            labelForCopy.Text = "Статус копирования";
                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}