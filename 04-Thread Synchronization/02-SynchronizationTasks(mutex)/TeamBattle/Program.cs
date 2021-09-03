using System;
using System.Threading;
using TeamBattle.NamespacePrint;
using TeamBattle.NamespaceTeams;
using TeamBattle.NamespaceSettings;

namespace TeamBattle
{
    class Program
    {
        private static readonly Mutex _mutex = new Mutex();

        private static void DoIt(Team a, Team b, string str)
        {
            new Thread(() =>
            {
                while (!Settings.DidHeWin)
                {
                    _mutex.WaitOne();
                        a.IncreaseInSolders();
                        Print.PrintFirstQuantity(a);
                        a.EnemyKilling(b);
                        Print.PrintSecondQuantity(b);

                        if (b.Quantity <= 0)
                        {
                            Settings.DidHeWin = true;
                            Print.PrintThreadWon(str);
                            Thread.Sleep(3000);
                            break;
                        }
                    _mutex.ReleaseMutex();
                    Thread.Sleep(100);
                }
            }).Start();
        }

        static void Main()
        {
            Console.CursorVisible = false;

            var t1 = new Team();
            var t2 = new Team();

            Print.PrintFirstTeam(t1);
            Print.PrintSecondTeam(t2);

            DoIt(t1, t2, "Поток №1");
            DoIt(t2, t1, "Поток №2");
        }
    }
}