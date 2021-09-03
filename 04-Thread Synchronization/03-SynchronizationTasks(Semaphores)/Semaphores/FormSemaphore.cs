using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MyThreadInfo;

namespace Semaphores
{
    public partial class FormSemaphor : Form
    {
        private static readonly object _locker = new object();
        private static Semaphore _semaphore;
        private static List<ThEnc> _threadsNumeric;
        private static int _countThreadsNumeric;
        private static int _initCount;

        public FormSemaphor()
        {
            InitializeComponent();
            _initCount = (int)NumericInitialCount.Value;
            _semaphore = new Semaphore((int)NumericInitialCount.Value, (int)NumericInitialCount.Maximum);
            _threadsNumeric = new List<ThEnc>();
        }

        private void ButtonCreateStream_Click(object sender, EventArgs e)
        {
            ThEnc tmpTh = new ThEnc(_countThreadsNumeric++)
            {
                MyTh = new Thread(WorkingNumeric) { IsBackground = true }
            };


            listBoxGeneratedStreams.Items.Add($"Поток {tmpTh.IdThread} --> создан");

            _threadsNumeric.Add(tmpTh);
        }
        private void ListBoxGeneratedStreams_DoubleClick(object sender, EventArgs e)
        {

            MovingInWaitingListBox();

            new Thread(RunStart) { IsBackground = true }.Start();
        }

        public void NumericInitialCount_ValueChanged(object sender, EventArgs e)
        {
            if (_initCount < (int)NumericInitialCount.Value)
            {
                _semaphore.Release();
                _initCount = (int)NumericInitialCount.Value;
            }
            else if (_initCount > (int)NumericInitialCount.Value)
            {
                _initCount = (int)NumericInitialCount.Value;

                lock (_locker)
                {
                    if (listBoxOperatingStreams.Items.Count > 0)
                    {
                        int nameThread = GetIdThread(0);

                        for (int i = 0; i < _threadsNumeric.Count; i++)
                        {
                            if (_threadsNumeric[i].IdThread == nameThread)
                            {
                                _threadsNumeric[i].ThIsAlive = false;
                                _threadsNumeric[i].IdListOper = -1;
                                _threadsNumeric.RemoveAt(i);
                                break;
                            }
                        }

                        listBoxOperatingStreams.Items.RemoveAt(0);

                        for (int i = 0; i < listBoxOperatingStreams.Items.Count; i++)
                        {
                            GetIdThread(i);

                            for (int j = 0; j < _threadsNumeric.Count; j++)
                            {
                                if (_threadsNumeric[j].IdThread == GetIdThread(i))
                                {
                                    _threadsNumeric[j].IdListOper -= 1;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void WorkingNumeric(object nameThread)
        {
            int count = 0;
            ThEnc thEnc = null;

            foreach (var item in _threadsNumeric)
            {
                if (item.IdThread == (int)nameThread)
                {
                    thEnc = item;
                }
            }

            while (thEnc.ThIsAlive)
            {
                lock (_locker)
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke((MethodInvoker)(() =>
                        {
                            if (listBoxOperatingStreams.Items.Count > 0)
                                listBoxOperatingStreams.Items[thEnc.IdListOper] = $"Поток {thEnc.IdThread} --> {count++}";
                        }));
                    }
                    else
                    {
                        if (listBoxOperatingStreams.Items.Count > 0)
                            listBoxOperatingStreams.Items[thEnc.IdListOper] = $"Поток {thEnc.IdThread} --> {count++}";
                    }
                }
                Thread.Sleep(1000);
            }
        }

        private void RunStart()
        {
            _semaphore.WaitOne();

            lock (_locker)
            {
                if (listBoxWaitingStreams.Items.Count > 0)
                {
                    if (InvokeRequired)
                        BeginInvoke((MethodInvoker)(() =>
                        {
                            MovingInOperatingListBox();
                            listBoxWaitingStreams.Items.RemoveAt(0);
                        }));
                    else
                    {
                        MovingInOperatingListBox();
                        listBoxWaitingStreams.Items.RemoveAt(0);
                    }
                }
            }
        }

        private int GetIdThread(int index)
        {
            if (listBoxOperatingStreams.Items.Count > 0)
            {
                string str = listBoxOperatingStreams.Items[index].ToString();
                str = str.Remove(str.IndexOf(" -->"));
                str = str.Remove(0, "Поток ".Length);
                int.TryParse(str, out int nameThread);
                return nameThread;
            }
            return -1;
        }

        private void MovingInWaitingListBox()
        {
            lock (_locker)
            {
                if (listBoxGeneratedStreams.SelectedIndex >= 0 && listBoxGeneratedStreams.SelectedIndex < listBoxGeneratedStreams.Items.Count)
                {
                    string s = listBoxGeneratedStreams.Items[listBoxGeneratedStreams.SelectedIndex].ToString();
                    int.TryParse(string.Join(string.Empty, s.Where(c => char.IsDigit(c))), out int nameThread);

                    foreach (var item in _threadsNumeric)
                    {
                        if (item.IdThread == nameThread)
                        {
                            listBoxWaitingStreams.Items.Add($"Поток {item.IdThread} --> ожидает");
                            listBoxGeneratedStreams.Items.RemoveAt(listBoxGeneratedStreams.SelectedIndex);
                        }
                    }
                }
            }
        }

        private void MovingInOperatingListBox()
        {
            string s = listBoxWaitingStreams.Items[0].ToString();
            int.TryParse(string.Join(string.Empty, s.Where(c => char.IsDigit(c))), out int nameThread);

            foreach (var item in _threadsNumeric)
            {
                if (item.IdThread == nameThread)
                {
                    listBoxOperatingStreams.Items.Add($"Поток {item.IdThread}");
                    item.ThIsAlive = true;
                    item.IdListOper = listBoxOperatingStreams.Items.Count - 1;
                    item.MyTh.Start(item.IdThread);
                }
            }
        }
    }
}