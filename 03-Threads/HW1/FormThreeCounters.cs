using System;
using System.Threading;
using System.Windows.Forms;

//1.	Написать приложение, показывающее диалоговое окно с тремя счетчиками и тремя кнопками: Старт, Стоп, Сброс.
//    Старт запускает счетчики(интервалы обновления — 0.5 сек, 1 сек, 1.5 сек), Стоп останавливает, Сброс останавливает
//   и сбрасывает счетчики в 0. Увеличение счетчиков реализовать в отдельных рабочих потоках.


namespace HW1
{
    public partial class FormThreeCounters : Form
    {
        public Thread T1 { get; set; }
        public Thread T2 { get; set; }
        public Thread T3 { get; set; }

        public FormThreeCounters()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            T1 = new Thread(new ThreadStart(ThreadProc1))
            {
                IsBackground = true
            };
            T1.Start();

            T2 = new Thread(new ThreadStart(ThreadProc2))
            {
                IsBackground = true
            };
            T2.Start();

            T3 = new Thread(new ThreadStart(ThreadProc3))
            {
                IsBackground = true
            };
            T3.Start();


            Start.Enabled = false;
            Reset.Enabled = true;
            Stop.Enabled = true;
        }

        private void ThreadProc1()
        {
            for (int i = 1; i <= int.MaxValue; i++)
            {
                if (InvokeRequired)
                    BeginInvoke(new Action<string>(s => { LabelCounterOne.Text = s; }), i.ToString());
                else
                    LabelCounterOne.Text = i.ToString();

                Thread.Sleep(500);
            }
        }

        private void ThreadProc2()
        {
            for (int i = 1; i <= int.MaxValue; i++)
            {
                if (InvokeRequired)
                    BeginInvoke(new Action<string>(s => { LabelCounterTwo.Text = s; }), i.ToString());
                else
                    LabelCounterOne.Text = i.ToString();

                Thread.Sleep(1000);
            }
        }

        private void ThreadProc3()
        {
            for (int i = 1; i <= int.MaxValue; i++)
            {
                if (InvokeRequired)
                    BeginInvoke(new Action<string>(s => { LabelCounterThree.Text = s; }), i.ToString());
                else
                    LabelCounterOne.Text = i.ToString();

                Thread.Sleep(1500);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            T1.Abort();
            T2.Abort();
            T3.Abort();
            Start.Enabled = true;
            Reset.Enabled = false;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            T1.Abort();
            T2.Abort();
            T3.Abort();
            LabelCounterOne.Text = "0";
            LabelCounterTwo.Text = "0";
            LabelCounterThree.Text = "0";
            Start.Enabled = true;
            Reset.Enabled = false;
            Stop.Enabled = false;
        }
    }
}
