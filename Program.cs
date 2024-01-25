using System;

namespace Mission2
{
    class DiceSimulator
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            
            Console.Write("How many dice rolls would you like to simulate? "); //prompt user
            string input = Console.ReadLine()!; // Adding ! to show non-null

            if (!string.IsNullOrEmpty(input))
            {
                int numRolls = int.Parse(input);

                //run the simulation
                DiceRoller diceRoller = new DiceRoller();
                int[] results = diceRoller.SimulateRolls(numRolls);

                //display results
                Console.WriteLine("\n--SIMULATION RESULTS--");
                Console.WriteLine("Each \"*\" represents 1% of the total number of rolls\n");

                //show graph
                for (int i = 2; i <= 12; i++)
                {
                    int percentage = (results[i] * 100 + numRolls / 2) / numRolls;
                    string asterisks = new string('*', percentage);
                    Console.WriteLine($"{i}: {asterisks}");
                }

                Console.WriteLine($"\nTotal number of rolls: {numRolls}.");
                Console.WriteLine("Thank you for using the dice throwing simulator!");
            }
            //alert if user enters nothing
            else
            {
               Console.WriteLine("Invalid input. Please enter a valid number of rolls.");
            }
        }
    }
}