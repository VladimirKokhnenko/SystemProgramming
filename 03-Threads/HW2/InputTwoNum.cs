using System;
using System.Threading;
using System.Windows.Forms;

//2.Написать приложение, показывающее диалоговое окно с двумя полями ввода, кнопками и статиками.В полях ввода
//  пользователь водит числа, после по нажатию кнопок стартуют отдельные потоки, считающие суммы
//  введенных чисел от 1 до этих чисел и с интервалом в 0.5 сек показывающие в статиках промежуточные результаты.


namespace HW2
{
    public partial class InputTwoNum : Form
    {
        public Thread T1 { get; set; }
        public Thread T2 { get; set; }
        public bool CanWeStartIt1 { get; set; }
        public bool CanWeStartIt2 { get; set; }

        public InputTwoNum()
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

            Stop.Enabled = true;
            Start.Enabled = false;
        }

        private void ThreadProc1()
        {
            int max = Convert.ToInt32(InputOne.Text);
            int n = Convert.ToInt32(OutOne.Text);

            for (int i = 0; i <= max; i++)
            {
                if (InvokeRequired)
                    BeginInvoke(new Action<int>(s => { OutOne.Text = (n += s).ToString(); }), i);
                else
                    OutOne.Text = (n += i).ToString();

                Thread.Sleep(500);
            }
        }

        private void ThreadProc2()
        {
            int max = Convert.ToInt32(InputTwo.Text);
            int n = Convert.ToInt32(OutTwo.Text);

            for (int i = 0; i <= max; i++)
            {
                if (InvokeRequired)
                    BeginInvoke(new Action<int>(s => { OutTwo.Text = (n += s).ToString(); }), i);
                else
                    OutOne.Text = (n += i).ToString();

                Thread.Sleep(500);
            }
        }

        private void InputOne_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(InputOne.Text) > 0)
                    CanWeStartIt1 = true;
                if (CanWeStartIt1 && CanWeStartIt2)
                    Start.Enabled = true;
            }
            catch (FormatException) { }
        }


        private void InputTwo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(InputTwo.Text) > 0)
                    CanWeStartIt2 = true;
                if (CanWeStartIt1 && CanWeStartIt2)
                    Start.Enabled = true;
            }
            catch (FormatException) { }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            T1.Abort();
            T2.Abort();

            OutOne.Text = "0";
            OutTwo.Text = "0";
            InputOne.Text = String.Empty;
            InputTwo.Text = String.Empty;

            Stop.Enabled = false;
            Start.Enabled = false;
            CanWeStartIt1 = false;
            CanWeStartIt2 = false;
        }
    }
}
