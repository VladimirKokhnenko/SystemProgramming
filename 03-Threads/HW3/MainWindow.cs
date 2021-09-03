using System;
using System.Threading;
using System.Windows.Forms;

//3. Написать приложение, показывающее диалоговое окно с одной кнопкой.При нажатии на эту кнопку открывается
//  второе немодальное диалоговое окно, в котором в диапазоне от 1 до 20 с интервалом в 0.5 сек изменяется
//  счетчик. Когда счетчик доходит до 20, немодальное диалоговое окно закрывается. Показ немодального диалогового
//  окна и увеличение счетчика реализовать в отдельном потоке пользовательского интерфейса.


namespace HW3
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Window_Click(object sender, EventArgs e)
        {
            var myForm = new NonModalWindow();
            myForm.Show();

            ParameterizedThreadStart par = new ParameterizedThreadStart(ThreadProc);

            var T = new Thread(par)
            {
                IsBackground = true
            };
            T.Start(myForm);
        }

        private void ThreadProc(object form)
        {
            for (int i = 0; i <= 20; i++)
            {
                if (InvokeRequired)
                    BeginInvoke(new Action<string>(s => { (form as NonModalWindow).PropCounter.Text = s; }), i.ToString());
                else
                    (form as NonModalWindow).PropCounter.Text = i.ToString();

                Thread.Sleep(500);
            }
            (form as NonModalWindow).CloseForm();
        }
    }
}
