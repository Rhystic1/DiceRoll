using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    internal class Calculations
    {
        Random rnd = new Random();
        int min = 1;
        int max;
        
        public int SelectDie()
        {
            Console.WriteLine("Please type in the number of the die that you need.");
            try
            {
                max = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("You must select a valid number.");
                SelectDie();
            }

            return max;
        }
        public int GenerateResult(int min, int max)
        {
            int randomResult = rnd.Next(min, max);
            Console.WriteLine("You rolled a... " + randomResult);
            Console.WriteLine("");
            Console.WriteLine("Do you want to roll another die? Press any key except N to proceed.");
            Console.WriteLine("");
            return randomResult;
        }
    }
}
