using System;
using System.Collections.Generic;
using System.Text;
using TaskOne.Interfeces;

namespace TaskOne.ChainTypes
{
    public class ChainSecondType : ICharacterChains
    {
        private readonly char _ch;
        public ChainSecondType(int x)
        {
            X = x;
            _ch = RandChar();
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Clear(int y)
        {
            Output.Print.Show(ConsoleColor.Black, ' ', X, --y);
        }

        public void Print(int y)
        {
            Output.Print.Show(ConsoleColor.Green, _ch, X, y);
        }

        private char RandChar()
        {
            var rand = new Random();
            int n;

            while (true)
            {
                n = rand.Next(33, 501);
                if (!(n > 126 && n < 161))
                    break;
            }

            return (char)n;
        }
    }
}