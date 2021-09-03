using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamAtWinForms
{
    public partial class FormMainProject : Form
    {
        public FormOperatingDisplay ODis { get; set; } = new FormOperatingDisplay();
        public static List<ForTheReport> StaticReport { get; set; }
        public static List<WordInfo> GroupedCollectionWords { get; set; }
        private static readonly string[] _separators = { ",", ".", "!", "?", ";", ":", " ", "	", "(", ")" };

        public FormMainProject()
        {
            InitializeComponent();
        }

        private void FilePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FBrDialog.ShowDialog() == DialogResult.OK)
                toolStripPathText.Text = FBrDialog.SelectedPath;
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormIllegalWords().ShowDialog();
        }

        private void ToolStripStart_Click(object sender, EventArgs e)
        {

            if (IlRes.Words.Count > 0)
            {
                listViewFile.Items.Clear();
                listViewTopWords.Items.Clear();

                if (InfoWordsToFile.Report.Count > 0)
                    InfoWordsToFile.Report.Clear();

                ODis.ShowDialog();
                StaticReport = InfoWordsToFile.Report;

                GroupedCollectionWords = InfoWordsToFile.GetGroupedCollectionWords();

                GroupedCollectionWords.Sort((WordInfo w1, WordInfo w2) =>
                {
                    if (w1.CountWords > w2.CountWords) return -1;
                    if (w1.CountWords < w2.CountWords) return 1;
                    else return 0;
                });

                for (int i = 0; i < InfoWordsToFile.Report.Count; i++)
                {
                    listViewFile.Items.Add(InfoWordsToFile.Report[i].FileName);
                    listViewFile.Items[i].SubItems.Add(InfoWordsToFile.Report[i].FilePath);
                    listViewFile.Items[i].SubItems.Add(InfoWordsToFile.Report[i].FileSize.ToString());
                    listViewFile.Items[i].SubItems.Add(InfoWordsToFile.Report[i].FileCountReplacements.ToString());
                }

                for (int i = 0; i < GroupedCollectionWords.Count; i++)
                {
                    listViewTopWords.Items.Add(GroupedCollectionWords[i].Word);
                    listViewTopWords.Items[i].SubItems.Add(GroupedCollectionWords[i].CountWords.ToString());
                }
            }
            else
            {
                MessageBox.Show("Прежде чем запустить процесс поиска слов необходимо создать или загрузить список " +
                    "запрещенных слов");
            }
        }

        private async void ToolStripSaveReport_ClickAsync(object sender, EventArgs e)
        {
            if (StaticReport?.Count > 0)
            {
                string nameForm = Text;
                Text = "Начался процесс копирования файлов";
                toolStripSaveReport.Enabled = false;

                try
                {
                    await Task.Factory.StartNew(() =>
                    {
                        Directory.CreateDirectory(toolStripPathText.Text);

                        foreach (var item in StaticReport)
                        {
                            File.Copy(
                            sourceFileName: item.FilePath,
                            destFileName: $"{toolStripPathText.Text}\\origin {item.FileName}",
                            overwrite: true);
                        }

                        foreach (ForTheReport file in StaticReport)
                        {
                            List<string> readOutFile = new List<string>();

                            using (StreamReader sr = new StreamReader(file.FilePath))
                            {
                                string line;

                                while ((line = sr.ReadLine()) != null)
                                {
                                    string[] words = line.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
                                    string tmpLine = string.Empty;

                                    foreach (var ilWord in IlRes.Words)
                                    {
                                        for (int i = 0; i < words.Length; i++)
                                        {
                                            if (words[i].ToLower() == ilWord)
                                                words[i] = "*******";
                                            tmpLine += $" {words[i]}";
                                        }
                                    }
                                    readOutFile.Add(tmpLine);
                                }
                            }

                            using (StreamWriter sw = new StreamWriter($"{toolStripPathText.Text}\\copy {file.FileName}",
                                false, System.Text.Encoding.Default))
                            {
                                foreach (var item in readOutFile)
                                {
                                    sw.WriteLine(item);
                                }
                            }
                        }

                        using (StreamWriter sw = new StreamWriter($"{toolStripPathText.Text}\\Report.txt",
                           false, System.Text.Encoding.Default))
                        {
                            foreach (var item in GroupedCollectionWords)
                            {
                                sw.WriteLine($"{item.Word} {item.CountWords}");
                            }
                        }

                        using (StreamWriter sw = new StreamWriter($"{toolStripPathText.Text}\\Logs.txt",
                           false, System.Text.Encoding.Default))
                        {
                            foreach (var item in MyLog.Log)
                            {
                                sw.WriteLine($"{item}\n{string.Empty}");
                            }
                        }

                        MessageBox.Show("Копирование завершено");
                        Text = nameForm;
                        toolStripSaveReport.Enabled = true;
                    });
                }
                catch (Exception ex)
                {
                    MyLog.Log.Add(ex.ToString());
                }
            }
        }
    }
}