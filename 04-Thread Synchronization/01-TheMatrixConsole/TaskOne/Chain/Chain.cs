using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using TaskOne.Interfeces;

namespace TaskOne.ChainTypes
{
    public class Chain : IChains
    {
        private const int startPause = 0;
        private const int finishPause = 200;

        private readonly int _startRange;
        private readonly int _finishRange;
        private readonly int _timePause;
        private readonly List<ICharacterChains> Strand;

        public int X { get; set; }

        public Chain()
        {
            var rand = new Random();

            X = rand.Next(0, Console.WindowWidth);
            _startRange = 3;
            _finishRange = 10;
            _timePause = rand.Next(startPause, finishPause);
            Strand = GenerateChain();
        }

        public void ShowChain()
        {
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                for (int j = 0; j <= (i < Strand.Count - 1 ? i : Strand.Count - 1); j++)
                {
                    Strand[j].Print(i - j);
                    if (i > Strand.Count - 1)
                        Strand[j].Clear(i - j);
                }
                if (i == Console.WindowHeight - 1)
                {
                    int r = 1;
                    for (int k = Strand.Count - 1; k >= 0; k--)
                    {
                        for (int l = Strand.Count - k; l < Strand.Count; l++)
                        {
                            if (l == Strand.Count - 1)
                                Strand[l].Clear(i - l + r);
                            Strand[l].Print(i - l + r);
                        }
                        if (k == 0)
                            Strand[0].Clear(i + 1);

                        r++;
                        Thread.Sleep(_timePause);
                    }
                }
                Thread.Sleep(_timePause);
            }
        }

        private List<ICharacterChains> GenerateChain()
        {
            var strand = new List<ICharacterChains>(new Random().Next(_startRange, _finishRange + 1))
            {
                new ChainFirstType(X),
                new ChainSecondType(X)
            };

            for (int i = 2; i < strand.Capacity; i++)
                strand.Add(new ChainThirdType(X));

            return strand;
        }
    }
}
