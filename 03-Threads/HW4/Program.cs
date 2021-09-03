using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//4.	Написать приложение, показывающее диалоговое окно с полем ввода для указания каталога и кнопкой для показа
//    немодального диалогового окна.В этом окне показывается постоянно обновляющаяся информация о количестве файлов
//    в этом каталоги и их суммарном размере.


namespace HW4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DialogWithCatalog());
        }
    }
}
