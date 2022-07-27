using System;
using static sandsynlighedberegner_test.Dice;

namespace sandsynlighedberegner_test // Note: actual namespace depends on the project name.
{
    internal class Program : sandsynlighedberegner_test.Dice
    {
        static void Main(string[] args)
        {
            GetDiceAmount();
            Console.ReadKey();
        }
        
    }
}