using System;
using System.Threading;
using AirReconnaissance.Resource;
using AirReconnaissance.NamespacePrint;

namespace AirReconnaissance
{
    class Program
    {
        public static void GetExplorationData(object numThread)
        {
            var rand = new Random();

            int x = rand.Next(0, Console.WindowWidth);
            int y = rand.Next(0, Console.WindowHeight);

            int count = 0;

            for (int i = y; i < Console.WindowHeight; i++)
            {
                for (int j = x; j < Console.WindowWidth; j++)
                {
                    if (ClassMap.GetMap(i, j) == ClassMap.Target)
                        count++;
                }
            }

            Print.PrintResult((int)numThread, x, y, count);
        }

        static void Main()
        {
            Console.CursorVisible = false;

            for(int i = 0; i < 10; i++)
            {
                new Thread(GetExplorationData).Start(i);
            }

            Console.ReadKey();
            Console.CursorVisible = true;
        }
    }
}