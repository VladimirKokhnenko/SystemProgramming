using System;
using System.Collections.Generic;
using System.Text;

namespace TaskOne.Interfeces
{
    interface ICharacterChains
    {
        int X { get; set; }
        int Y { get; set; }

        void Print(int y);
        void Clear(int y);
    }
}
