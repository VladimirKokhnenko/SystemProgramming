using System;
using VinnieFluffAndPearls.Common;
using VinnieFluffAndPearls.CommonResource;

namespace VinnieFluffAndPearls.Output
{
    public static class Output
    {
        private static readonly object locker = new object();
        public static void OutVinni()
        {
            lock (locker)
            {
                Console.SetCursorPosition(Settings.xVinni, Settings.yVinni);
                Console.WriteLine("Винни");
                Console.SetCursorPosition(Settings.xVCap, Settings.yVCap);
                Console.WriteLine(Resource.Capacity);
            }
        }

        public static void OutBees()
        {
            lock (locker)
            {
                Console.SetCursorPosition(Settings.xBees, Settings.yBees);
                Console.WriteLine("Пчелы");
                Console.SetCursorPosition(Settings.xBCap, Settings.yBCap);
                Console.WriteLine(Resource.Capacity);
            }
        }

        public static void VinniDied()
        {
            lock (locker)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Винни приказал долго жить");
            }
        }
    }
}