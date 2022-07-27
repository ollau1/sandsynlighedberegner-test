using System;
using static sandsynlighedberegner_test.Dice;

namespace sandsynlighedberegner_test
{
    internal class Program : sandsynlighedberegner_test.Dice
    {
        static void Main(string[] args)
        {
            //Kald af GetDiceAmount metode
            GetDiceAmount();
            Console.ReadKey();
        }
        
    }
}