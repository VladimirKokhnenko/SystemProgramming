using System;
using TeamBattle.NamespaceTeams;
using TeamBattle.NamespaceSettings;

namespace TeamBattle.NamespacePrint
{
    public static class Print
    {
        public static void OutputQuantity(Team team, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("   ");
            Console.Write(team.Quantity);
        }

        public static void PrintFirstTeam(Team t)
        {
            Console.SetCursorPosition(Settings.xFName, Settings.yFName);
            Console.Write(Settings.FName);
            Console.SetCursorPosition(Settings.xFQuantity, Settings.yFQuantity);
            Console.Write(t.Quantity);
        }

        public static void PrintSecondTeam(Team t)
        {
            Console.SetCursorPosition(Settings.xSName, Settings.ySName);
            Console.Write(Settings.SName);
            Console.SetCursorPosition(Settings.xSQuantity, Settings.ySQuantity);
            Console.Write(t.Quantity);
        }

        public static void PrintFirstQuantity(Team t)
        {
            Console.SetCursorPosition(Settings.xFQuantity, Settings.yFQuantity);
            Console.Write("   ");
            Console.SetCursorPosition(Settings.xFQuantity, Settings.yFQuantity);
            Console.Write(t.Quantity);
        }

        public static void PrintSecondQuantity(Team t)
        {
            Console.SetCursorPosition(Settings.xSQuantity, Settings.ySQuantity);
            Console.Write("   ");
            Console.SetCursorPosition(Settings.xSQuantity, Settings.ySQuantity);
            Console.Write(t.Quantity);
        }

        public static void PrintThreadWon(string str)
        {
            Console.SetCursorPosition(Settings.xWon, Settings.yWon);
            Console.Write($"{str} победил");
        }
    }
}