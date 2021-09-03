using System;

namespace TaskOne.Output
{
    public static class Print
    {
        private static readonly object locker = new object();

        public static void Show(ConsoleColor color, char ch, int x, int y)
        {
            lock (locker)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(x, y);
                Console.Write(ch);
            }
        }
    }

    //public static class Print
    //{
    //    public static void Show(ConsoleColor color, char ch, int x, int y)
    //    {
    //        lock (typeof(Print))
    //        {
    //            Console.ForegroundColor = color;
    //            Console.SetCursorPosition(x, y);
    //            Console.Write(ch);
    //        }
    //    }
    //}
}