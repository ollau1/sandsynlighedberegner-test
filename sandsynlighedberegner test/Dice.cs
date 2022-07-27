using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sandsynlighedberegner_test;

namespace sandsynlighedberegner_test
{
    public class Dice
    {
        //Metode til valg af hvor mange terninger der skal slås/kastes.
        public static int GetDiceAmount()
        {
            Console.WriteLine("Hvor mange terninger vil du kaste med?");
            int dice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            DiceProbability(dice, MakeDice(dice));
            return dice;
        }
        //Metode til at lave 1-5 terninger og return summen.
        public static int MakeDice(int dice)
        {
            int diceSum = 0;
            if (dice == 1)
            {
                Random random = new Random();
                int dice1 = random.Next(1, 7);
                Console.WriteLine("Dice 1 = " + dice1);
                diceSum = dice1;
                Console.WriteLine(diceSum);
                return diceSum;
            }
            if (dice == 2)
            {
                Random random = new Random();
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                Console.WriteLine("Dice 1 = " + dice1);
                Console.WriteLine("Dice 2 = " + dice2);
                diceSum = dice1 + dice2;
                Console.WriteLine("Dice sum = " + diceSum);
                return diceSum;
            }
            else if (dice == 3)
            {
                Random random = new Random();
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int dice3 = random.Next(1, 7);
                Console.WriteLine("Dice 1 = " + dice1);
                Console.WriteLine("Dice 2 = " + dice2);
                Console.WriteLine("Dice 3 = " + dice3);
                diceSum = dice1 + dice2 + dice3;
                Console.WriteLine("Dice sum = " + diceSum);
                return diceSum;
            }
            else if (dice == 4)
            {
                Random random = new Random();
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int dice3 = random.Next(1, 7);
                int dice4 = random.Next(1, 7);
                Console.WriteLine("Dice 1 = " + dice1);
                Console.WriteLine("Dice 2 = " + dice2);
                Console.WriteLine("Dice 3 = " + dice3);
                Console.WriteLine("Dice 4 = " + dice4);
                diceSum = dice1 + dice2 + dice3 + dice4;
                Console.WriteLine("Dice sum = " + diceSum);
                return diceSum;
            }
            else if (dice == 5)
            {
                Random random = new Random();
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int dice3 = random.Next(1, 7);
                int dice4 = random.Next(1, 7);
                int dice5 = random.Next(1, 7);
                Console.WriteLine("Dice 1 = " + dice1);
                Console.WriteLine("Dice 2 = " + dice2);
                Console.WriteLine("Dice 3 = " + dice3);
                Console.WriteLine("Dice 4 = " + dice4);
                Console.WriteLine("Dice 5 = " + dice5);
                diceSum = dice1 + dice2 + dice3 + dice4 + dice5;
                Console.WriteLine("Dice sum = " + diceSum);
                return diceSum;
            }
            else
            {
                Console.WriteLine("DER ER IKKE SÅ MANGE TERNINGER");
                return diceSum;
            }
                    
        }
        //Metode til at udregne og udskrive chancen for slaget.
        static void DiceProbability(int dice, int diceSum)
        {

            double[,] probabilities = new double[dice + 1, 6 * dice + 1];
            for (int i = 1; i <= 6; i++)
                //vi tager 2. plads og di
                probabilities[1, i] = 1 / 6.0;
            //Her beregner vi alle mulighederne
            for (int i = 2; i <= dice; i++)
                for (int j = i - 1; j <= 6 * (i - 1); j++)
                    for (int k = 1; k <= 6; k++)
                    {
                        //Her indsætter vi dem i vores multidimensional array "probabilities"
                        probabilities[i, j + k] += (probabilities[i - 1, j] *
                                         probabilities[1, k]);
                    }
            //Her udskriver vi % chancen for det slag man slog
            for (int i = dice; i <= 6 * dice; i++)
            {
                if (diceSum == i)
                {
                    double val = (probabilities[dice, i] * 100);
                    Console.WriteLine($"{i} {val:N3} %");
                }
            }
        }
    }
}