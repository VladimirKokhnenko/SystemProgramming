using System;
using System.Threading;

namespace AirReconnaissance.NamespacePrint
{
    public static class Print
    {
        private static readonly Mutex _mutex = new Mutex();

        public static void PrintResult(int numThread, int x, int y, int count)
        {
            _mutex.WaitOne();
                Console.SetCursorPosition(0, numThread);
                Console.Write($"Поток №{numThread};" +
                    $" Начальные координаты: X = {x}, Y = {y};" +
                    $" Целей обнаружено = {count};");
            _mutex.ReleaseMutex();
        }
    }
}