using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceRoller // randomly roll the dice
    {
        private readonly Random random = new Random();

        public int[] SimulateRolls(int numRolls)
        {
            int[] results = new int[13]; // 

            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = random.Next(1, 7); //roll twice
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2; 

                results[sum]++; //append array
            }

            return results;
        }
    }
}
