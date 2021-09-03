using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//4. Написать приложение, показывающее диалоговое окно с полем ввода для указания каталога и кнопкой для показа
//  немодального диалогового окна.В этом окне показывается постоянно обновляющаяся информация о количестве файлов
//  в этом каталоги и их суммарном размере.


namespace HW4
{
    public partial class DialogWithCatalog : Form
    {
        public DialogWithCatalog()
        {
            InitializeComponent();
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(TInputPath.Text))
            {
                var newForm = new FormInfo(TInputPath.Text);
                newForm.Show();

                ParameterizedThreadStart par = new ParameterizedThreadStart(ThreadProc);

                var T = new Thread(par)
                {
                    IsBackground = true
                };
                T.Start(newForm);

            }
            else
            {
                MessageBox.Show("Некорректное указание пути, повторите ввод!!!");
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ThreadProc(object form)
        {
            try
            {
                while (true)
                {
                    if (InvokeRequired)
                        BeginInvoke(new Action<FormInfo, string>(ProcessDirectory), (form as FormInfo), (form as FormInfo).Path);
                    else
                        ProcessDirectory((form as FormInfo), (form as FormInfo).Path);

                    Thread.Sleep(60000);

                    (form as FormInfo).LCountFiles.Text = "0";
                    (form as FormInfo).LScope.Text = "0";
                }
            }
            catch(UnauthorizedAccessException e)
            {
                (form as FormInfo).FormInfoClose();
                MessageBox.Show(e.Message);
            }
        }

        public static void ProcessDirectory(FormInfo form, string targetDirectory)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(form, fileName);

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(form, subdirectory);
        }

        public static void ProcessFile(FormInfo form, string path)
        {
            form.LCountFiles.Text = (Convert.ToInt64(form.LCountFiles.Text) + 1).ToString();
            form.LScope.Text = (Convert.ToInt64(form.LScope.Text) + new FileInfo(path).Length).ToString();
        }
    }
}
