using System;
using TaskOne.ChainTypes;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace TasksOne
{
    class Program
    {
        //const int STD_OUTPUT_HANDLE = -11;

        //[DllImport("kernel32.dll")]
        //static extern IntPtr GetStdHandle(int handle);

        //[DllImport("kernel32.dll", SetLastError = true)]
        //static extern bool SetConsoleDisplayMode(IntPtr ConsoleHandle, uint Flags, IntPtr NewScreenBufferDimensions);

        static void Main()
        {
            //Console.OutputEncoding = System.Text.Encoding.Unicode;

            //var hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            //SetConsoleDisplayMode(hConsole, 1, IntPtr.Zero);
            //Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            //Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            //Console.CursorVisible = false;

            //Console.SetWindowSize(80, 30);
            //Console.SetBufferSize(80, 30);
            
            Console.CursorVisible = false;

            bool exit = true;
            int count = 0;

            foreach (Process process in Process.GetProcesses())
            {
                // выводим id и имя процесса
                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
            }

            Console.WriteLine();
            Console.WriteLine("Id студии");
            Process proc = Process.GetProcessesByName("MatrixWithCore")[0];
            ProcessThreadCollection processThreads = proc.Threads;

            foreach (ProcessThread thread in processThreads)
            {
                Console.WriteLine($"ThreadId: {thread.Id}  StartTime: {thread.StartTime}");
            }


            //while (exit)
            //{
            //        if (Console.KeyAvailable)
            //            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            //                exit = false;


            //    (new Thread(() =>
            //    {
            //        new Chain().ShowChain();
            //    })
            //    {
            //        IsBackground = false,
            //        Priority = ThreadPriority.BelowNormal

            //    }).Start();




            //        Thread.Sleep(50);
            //}

            Console.ResetColor();
        }
    }
}


//var startInfo = new ProcessStartInfo()
//{
//    FileName = "cmd.exe",
//    Arguments = @"/k ""C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\VsDevCmd.bat"""//настраиваем консоль
// + @" && cl.exe mycode.c"//команда вызова компилятора
// + @" && exit",//закрываем консоль
//    WorkingDirectory = @"C:\Program Files (x86)\Microsoft Visual Studio 14.0\",
//    UseShellExecute = true
//};
//Process.Start(startInfo);

