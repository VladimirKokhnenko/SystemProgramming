using System;

namespace AirReconnaissance.NamespacePrint
{
    public static class Print
    {
        private static readonly object locker = new object();

        public static void PrintResult(int numThread, int x, int y, int count)
        {
            lock (locker)
            {
                Console.SetCursorPosition(0, numThread);
                Console.Write($"Поток №{numThread};" +
                    $" Начальные координаты: X = {x}, Y = {y};" +
                    $" Целей обнаружено = {count};");
            }
        }
    }
}