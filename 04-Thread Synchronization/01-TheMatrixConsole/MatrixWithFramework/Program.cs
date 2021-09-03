using System;
using TaskOne.ChainTypes;
using System.Threading;
using System.Runtime.InteropServices;

namespace TasksOne
{
    class Program
    {
        const int STD_OUTPUT_HANDLE = -11;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetStdHandle(int handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetConsoleDisplayMode(IntPtr ConsoleHandle, uint Flags, IntPtr NewScreenBufferDimensions);

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            SetConsoleDisplayMode(hConsole, 1, IntPtr.Zero);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);

            Console.CursorVisible = false;

            bool exit = true;

            while (exit)
            {
                if (Console.KeyAvailable)
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        exit = false;

                (new Thread(() =>
                {
                    new Chain().ShowChain();
                })
                { IsBackground = true }).Start();

                Thread.Sleep(500);
            }

            Console.ResetColor();
            Console.CursorVisible = true;
        }
    }
}