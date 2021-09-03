using System;
using System.Threading;
using VinnieFluffAndPearls.Common;
using VinnieFluffAndPearls.CommonResource;

namespace VinnieFluffAndPearls.Output
{
    public static class Output
    {
        private static readonly Mutex _mutex = new Mutex();

        public static void OutVinni()
        {
            _mutex.WaitOne();
            Console.SetCursorPosition(Settings.xVinni, Settings.yVinni);
            Console.WriteLine("Винни");
            Console.SetCursorPosition(Settings.xVCap, Settings.yVCap);
            Console.WriteLine(Resource.Capacity);
            _mutex.ReleaseMutex();
        }

        public static void OutBees()
        {
            _mutex.WaitOne();
            Console.SetCursorPosition(Settings.xBees, Settings.yBees);
            Console.WriteLine("Пчелы");
            Console.SetCursorPosition(Settings.xBCap, Settings.yBCap);
            Console.WriteLine(Resource.Capacity);
            _mutex.ReleaseMutex();
        }

        public static void VinniDied()
        {
            _mutex.WaitOne();
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Винни приказал долго жить");
            _mutex.ReleaseMutex();
        }
    }
}