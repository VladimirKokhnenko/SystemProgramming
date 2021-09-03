using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamAtWinForms
{
    public partial class FormIllegalWords : Form
    {
        public FormIllegalWords()
        {
            InitializeComponent();
        }

        private void FormIllegalWords_Load(object sender, EventArgs e)
        {
            foreach (var item in IlRes.Words)
            {
                listBoxIllegalWords.Items.Add(item);
            }
        }

        //
        // Обработчики кнопок
        //

        private void ButtonAddWord_Click(object sender, EventArgs e)
        {
            AddingWordInListIllegalWords();
        }

        private void ButtonDelWord_Click(object sender, EventArgs e)
        {
            if (listBoxIllegalWords.SelectedIndex >= 0 && listBoxIllegalWords.Items.Count > 0)
            {
                IlRes.Words.RemoveAt(listBoxIllegalWords.SelectedIndex);
                listBoxIllegalWords.Items.RemoveAt(listBoxIllegalWords.SelectedIndex);
                listBoxIllegalWords.Focus();
            }
        }

        private void ButtonDelList_Click(object sender, EventArgs e)
        {
            if (listBoxIllegalWords.Items.Count > 0)
            {
                IlRes.Words.Clear();
                listBoxIllegalWords.Items.Clear();
            }
        }

        private void ButtonAddFile_Click(object sender, EventArgs e)
        {
            WorkWithFile();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        // Обработчики листбокса
        //

        private void ListBoxIllegalWords_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxIllegalWords.SelectedIndex >= 0)
            {
                OffAllControls();
                textBoxEditWord.Enabled = true;
                textBoxEditWord.Text = listBoxIllegalWords.SelectedItem.ToString();
            }
        }

        private void ListBoxIllegalWords_Click(object sender, EventArgs e)
        {
            if (listBoxIllegalWords.SelectedIndex >= 0)
            {
                buttonDelWord.Enabled = true;
                buttonDelWord.Focus();
            }
        }

        //
        // Обработчики текстбоксов
        //

        private void TextBoxAddWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AddingWordInListIllegalWords();
            }
        }

        private void TextBoxEditWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                listBoxIllegalWords.Items[listBoxIllegalWords.SelectedIndex] = textBoxEditWord.Text;
                textBoxEditWord.Text = string.Empty;
                OnAllControls();
                textBoxEditWord.Enabled = false;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                textBoxEditWord.Text = string.Empty;
                OnAllControls();
                textBoxEditWord.Enabled = false;
            }
        }

        private void TextBoxAddFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                WorkWithFile();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                textBoxAddFile.Text = string.Empty;
            }
        }

        //
        // Вспомогательные методы
        //

        private void AddingWordInListIllegalWords()
        {
            if (textBoxAddWord.Text.Length > 0)
            {
                string str = textBoxAddWord.Text.Trim().ToLower();
                bool isThatAWord = false;

                if (listBoxIllegalWords.Items.Count > 0)
                {
                    foreach (var item in listBoxIllegalWords.Items)
                    {
                        if (item.ToString() == str)
                        {
                            isThatAWord = true;

                            MessageBox.Show("Такое слово уже есть в списке");

                            break;
                        }
                    }

                    if (!isThatAWord)
                    {
                        listBoxIllegalWords.Items.Add(str);
                        IlRes.Words.Add(str);
                    }
                }
                else
                {
                    listBoxIllegalWords.Items.Add(str);
                    IlRes.Words.Add(str);
                }

                textBoxAddWord.Text = string.Empty;
            }
        }

        private void OffAllControls()
        {
            listBoxIllegalWords.Enabled = false;
            buttonAddWord.Enabled = false;
            buttonAddFile.Enabled = false;
            buttonDelList.Enabled = false;
            buttonDelWord.Enabled = false;
            textBoxAddWord.Enabled = false;
            textBoxAddFile.Enabled = false;
        }

        private void OnAllControls()
        {
            listBoxIllegalWords.Enabled = true;
            buttonAddWord.Enabled = true;
            buttonAddFile.Enabled = true;
            buttonDelList.Enabled = true;
            buttonDelWord.Enabled = true;
            textBoxAddWord.Enabled = true;
            textBoxAddFile.Enabled = true;
        }

        private void WorkWithFile()
        {
            if (textBoxAddFile.Text.Length == 0)
            {
                var openFileDialog = new OpenFileDialog
                {
                    Filter = "TXT(*.txt)|*.txt",
                    Title = "Выберите файл",
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ReadFile(openFileDialog.FileName);
                    OnAllControls();
                }
            }
            else
            {
                try
                {
                    if (File.Exists(textBoxAddFile.Text))
                        ReadFile(textBoxAddFile.Text);
                    else
                        MessageBox.Show("Путь указан неверно");
                }
                catch (Exception ex)
                {
                    MyLog.Log.Add(ex.ToString());
                }
            }
        }

        private async void ReadFile(string path)
        {
            await Task.Run(() =>
            {
                try
                {
                    using (var streamRead = new StreamReader(path, System.Text.Encoding.Default))
                    {
                        string line;
                        bool isOn = false;

                        while ((line = streamRead.ReadLine()) != null)
                        {
                            foreach (var item in listBoxIllegalWords.Items)
                            {
                                if (item.ToString() == line.Trim().ToLower())
                                {
                                    isOn = true;
                                    break;
                                }
                            }

                            if (!isOn)
                            {
                                string str = line.Trim().ToLower();
                                listBoxIllegalWords.Items.Add(str);
                                IlRes.Words.Add(str);
                                isOn = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MyLog.Log.Add(ex.ToString());
                }
            });
        }
    }
}