using System;
using System.Threading;

namespace TeamBattle.NamespaceTeams
{
    public class Team
    {
        private static readonly Mutex _mutex = new Mutex();
        private const int startVal = 0;
        private const int endVal = 10;
        private readonly Random rand = new Random();

        public Team() => Quantity = 20;

        public int Quantity { get; set; }

        public void IncreaseInSolders()
        {
            _mutex.WaitOne();
                Quantity += rand.Next(startVal, endVal);
            _mutex.ReleaseMutex();
        }

        public void EnemyKilling(Team team)
        {
            _mutex.WaitOne();
                team.Quantity -= rand.Next(startVal, endVal);
            _mutex.ReleaseMutex();
        }
    }
}