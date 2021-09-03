using System;

namespace AirReconnaissance.Resource
{
    public static class ClassMap
    {
        private static readonly int[,] _map;
        public const int Target = 1;

        static ClassMap()
        {
            _map = new int[Console.WindowWidth, Console.WindowHeight];

            var rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                _map[rand.Next(0, Console.WindowWidth), rand.Next(0, Console.WindowHeight)] = Target;
            }
        }

        public static int GetMap(int i, int j) => _map[j, i];
    }
}