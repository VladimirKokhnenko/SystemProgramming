
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