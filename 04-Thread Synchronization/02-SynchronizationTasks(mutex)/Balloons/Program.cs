using System;
using System.Threading;
using Balloons.NamespaceCoor;
using Balloons.NameSpacePrint;

// 2. Шарики.Координаты заданного количества шариков изменяются на случайную величину по вертикали и горизонтали.
//  При выпадении шарика за нижнюю границу допустимой области шарик исчезает.
//  Изменение координат каждого шарика в отдельном процессе (потоке).


namespace Balloons
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            const int quantity = 10;

            int xW = Console.WindowWidth * 2;
            int yH = Console.WindowHeight * 2;

            var rand = new Random();

            for (int i = 0; i < quantity; i++)
            {
                new Thread((j) =>
                {
                    var cr = new Coor();

                    while (true)
                    {
                        cr.XNext = rand.Next(0, xW);
                        cr.YNext = rand.Next(0, yH);

                        Print.PrintBall(cr, (int)j);
                        Thread.Sleep(500 + (int)j);
                    }
                }).Start(i);
            }
        }
    }
}