using System;
using System.Threading;
using Balloons.NamespaceCoor;

namespace Balloons.NameSpacePrint
{
    public static class Print
    {
        private const char chBall = 'B';
        private const string chClear = "  ";

        private static readonly Mutex _mutex = new Mutex();
        public static void PrintBall(Coor coor, int num)
        {
            _mutex.WaitOne();
                if(coor.XNext >= 0 && coor.XNext < Console.WindowWidth &&
                    coor.YNext >= 0 && coor.YNext < Console.WindowHeight)
                {
                    Console.SetCursorPosition(coor.XPrev, coor.YPrev);
                    Console.Write(chClear);
                    Console.SetCursorPosition(coor.XNext, coor.YNext);
                    Console.Write($"{chBall}{num}");

                    coor.XPrev = coor.XNext;
                    coor.YPrev = coor.YNext;
                }
                else
                {
                    Console.SetCursorPosition(coor.XPrev, coor.YPrev);
                    Console.Write(chClear);
                }
            _mutex.ReleaseMutex();
        }
    }
}