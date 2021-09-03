using System;
using System.Threading;
using VinnieFluffAndPearls.Common;
using VinnieFluffAndPearls.CommonResource;

//1. Винни-Пух и пчелы.Заданное количество пчел добывают мед равными порциями, задерживаясь
//  в пути на случайное время. Винни-Пух потребляет мед порциями заданной величины за заданное время и
//  столько же времени может прожить без питания. Работа каждой пчелы реализуется в порожденном процессе (потоке).

namespace VinnieFluffAndPearls
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;


            var rand = new Random();



            var T = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    if (Resource.Capacity >= 0)
                    {
                        Resource.Capacity -= 10;
                        Output.Output.OutVinni();
                        Thread.Sleep(500);
                    }
                    else
                    {
                        Thread.Sleep(500);
                        if (Resource.Capacity >= 0)
                            break;
                    }
                }
                Output.Output.VinniDied();
            }))
            {
                IsBackground = true
            };
            T.Start();


            for (int i = 0; i < Settings.countBees; i++)
            {
                new Thread(new ThreadStart(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(rand.Next(Settings.timeLagS, Settings.timeLagE));
                        Resource.Capacity += Settings.portion;
                        Output.Output.OutBees();
                    }
                }))
                {
                    IsBackground = true
                }.Start();
            }

            T.Join();
            Console.CursorVisible = true;
        }
    }
}