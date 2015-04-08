using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins(10000);
            Console.WriteLine("Press any key to contiue...\n");
            Console.ReadKey();

            FlipForheads(10000);

            Console.WriteLine("Press any key to contiue...\n");
            Console.ReadKey();
        }

        /// <summary>
        ///Creates a coin flipping and counting feature 
        ///
        /// </summary>
        /// <param name="numberOfFlips"></param>
        public static void FlipCoins(int numberOfFlips)
        {
            //counter and random declaration
            int numberOfHeads = 0;
            int numberOfTails = 0;
            Random rng = new Random();

            //loop to flip coins and tally heads vs tails
            for (int i = 0; i <= numberOfFlips; i++)
            {
                //0 = heads, 1 = tails
                if (rng.Next(2) == 0)
                {
                    Console.WriteLine("You got heads!");
                    numberOfHeads++;
                }
                else
                {
                    Console.WriteLine("You got tails!");
                    numberOfTails++;
                }
                
            }

            //writes totals to console
            Console.WriteLine("We flipped a coin: " + numberOfFlips + " times.");
            Console.WriteLine("Number of heads: " + numberOfHeads);
            Console.WriteLine("Number of tails: " + numberOfTails);
        }

        /// <summary>
        /// Counts total heads, total flips, and runs until paramter number requirement met
        /// </summary>
        /// <param name="numberOfHeads"></param>
        public static void FlipForheads(int numberOfHeads)
        {
            //variable declarations
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;
            Random rng = new Random();
            //message to user
            Console.WriteLine("We are flipping a coin until we find " + numberOfHeads + " heads.");

            //continue loop until desired number of heads flipped
            while (numberOfHeadsFlipped != numberOfHeads)
            {
                //0 = heads, 1 = tails
                if (rng.Next(2) == 0)
                {
                    Console.WriteLine("You got heads!");
                    numberOfHeadsFlipped++;
                }
                else
                {
                    Console.WriteLine("You got tails. Try again!");

                }
                totalFlips++;

            }

            Console.WriteLine("It took " + totalFlips + " to find " + numberOfHeads + " heads.\n\n\n\n\n\n That's Flippin CRAZY!");
        }
    }
}
