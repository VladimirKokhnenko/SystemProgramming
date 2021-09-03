using System;

namespace TeamBattle.NamespaceTeams
{
    public class Team
    {
        private static readonly object locked = new object();
        private const int startVal = 0;
        private const int endVal = 10;
        private readonly Random rand = new Random();

        public Team() => Quantity = 20;

        public int Quantity { get; set; }

        public void IncreaseInSolders()
        {
            lock (locked)
            {
                Quantity += rand.Next(startVal, endVal);
            }
        }

        public void EnemyKilling(Team team)
        {
            lock (locked)
            {
                team.Quantity -= rand.Next(startVal, endVal);
            }
        }
    }
}