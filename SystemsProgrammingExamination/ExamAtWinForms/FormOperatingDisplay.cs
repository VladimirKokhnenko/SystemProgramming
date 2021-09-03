using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamAtWinForms
{
    public partial class FormOperatingDisplay : Form
    {
        private static readonly object _locked = new object();
        private static readonly string[] _separators = { ",", ".", "!", "?", ";", ":", " ", "	", "(", ")" };
        private CancellationTokenSource _cancellationTokenSource;
        private CancellationToken _cancellationToken;
        private readonly List<string> _fileSys = new List<string>();

        public FormOperatingDisplay()
        {
            InitializeComponent();
        }

        private async void ButtonStart_ClickAsync(object sender, EventArgs e)
        {
            MyLog.Log.Clear();
            progressBarSearchWords.Value = 0;

            var progress = new Progress<int>(t =>
            {
                int tmp = progressBarSearchWords.Value;
                if ((tmp += t) <= progressBarSearchWords.Maximum)
                    progressBarSearchWords.Value += t;
            });

            await Task.Factory.StartNew(() => WorkAsync(progress));
            Text = "Запущен поиск файлов";
            buttonPause.Enabled = true;
        }
        private async Task WorkAsync(IProgress<int> progress)
        {
            string mask = "*.txt";
            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;

            _fileSys.Clear();
            buttonStart.Enabled = false;

            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            Task[] diskTask = new Task[driveInfo.Length];

            for (int i = 0; i < driveInfo.Length; i++)
                diskTask[i] = SearchingFilesByMask(driveInfo[i].Name, mask, _cancellationToken);

            try
            {
                await Task.WhenAll(diskTask);
            }
            catch (TaskCanceledException ex)
            {
                lock (_locked)
                {
                    MyLog.Log.Add(ex.Message);
                }

                buttonStart.Enabled = true;
                buttonPause.Enabled = false;
            }
            catch (OperationCanceledException ex)
            {
                lock (_locked)
                {
                    MyLog.Log.Add(ex.Message);
                }

                buttonStart.Enabled = true;
                buttonPause.Enabled = false;
            }

            bool isCompleted = true;

            foreach (var task in diskTask)
                if (task.Status != TaskStatus.RanToCompletion)
                    isCompleted = false;

            if (isCompleted)
            {
                if (_fileSys.Count > 0)
                {
                    Text = "Идет поиск слов";

                    lock (_locked)
                    {
                        progressBarSearchWords.Maximum = _fileSys.Count;
                    }

                    Task[] fileTask = new Task[_fileSys.Count];


                    for (int i = 0; i < fileTask.Length; i++)
                        fileTask[i] = WordSearch(_fileSys[i], progress, _cancellationToken);

                    try
                    {
                        await Task.WhenAll(fileTask);
                    }
                    catch (TaskCanceledException ex)
                    {
                        lock (_locked)
                        {
                            progress.Report(1);
                            MyLog.Log.Add(ex.Message);
                        }
                        buttonStart.Enabled = true;
                        buttonPause.Enabled = false;
                    }
                    catch (OperationCanceledException ex)
                    {
                        lock (_locked)
                        {
                            progress.Report(1);
                            MyLog.Log.Add(ex.Message);
                        }
                        buttonStart.Enabled = true;
                        buttonPause.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        lock (_locked)
                        {
                            progress.Report(1);
                            MyLog.Log.Add(ex.Message);
                        }
                    }

                    Text = "Поиск завершен";
                    
                    Close();
                    //MessageBox.Show($"_fileSys.Count = {_fileSys.Count}; fileTask.Length = {fileTask.Length};" +
                    //    $"progressBarSearchWords.Value = {progressBarSearchWords.Value};" +
                    //    $"progressBarSearchWords.Maximum = {progressBarSearchWords.Value};");
                }
            }

            buttonStart.Enabled = true;
            buttonPause.Enabled = false;

        }

        private Task SearchingFilesByMask(string dirName, string mask, CancellationToken ct)
        {
            return Task.Run(() =>
            {
                var fileSys = new FileSystemWork();
                fileSys.FileMaskSearchNotRecursive(dirName, mask, ct);

                if (fileSys.FileNames.Count > 0)
                {
                    foreach (var item in fileSys.FileNames)
                    {
                        if (ct.IsCancellationRequested)
                        {
                            ct.ThrowIfCancellationRequested();
                        }
                        _fileSys.Add(item);
                    }
                }
            });
        }

        private Task WordSearch(object filePath, IProgress<int> progress, CancellationToken ct)
        {
            return Task.Run(() =>
            {
                if (!(filePath is string))
                    throw new ArgumentException("Параметр должен иметь тип string");

                string path = (string)filePath;

                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (ct.IsCancellationRequested)
                            ct.ThrowIfCancellationRequested();
                        string[] words = line.ToLower().Split(_separators, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var word in words)
                        {
                            foreach (var item in IlRes.Words)
                            {
                                if (ct.IsCancellationRequested)
                                    ct.ThrowIfCancellationRequested();
                                lock (_locked)
                                {
                                    if (word == item)
                                        InfoWordsToFile.Adding(path, word);
                                }
                            }
                        }
                    }
                }

                lock (_locked)
                {
                    progress.Report(1);
                }
            });
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        private void FormOperatingDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            progressBarSearchWords.Maximum = 1;
            progressBarSearchWords.Value = 0;
        }
    }
}