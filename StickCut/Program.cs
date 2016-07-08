using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StickCut
{
    class Program
    {
        /// <summary>
        ///     Main Method.
        /// </summary>
        /// <param name="args">Args.</param>
        static void Main(string[] args)
        {
            var startingStickLength = AskForStartingStickLength();
            var cutStickLength = AskForCutStickLength();          
            
            MinimumNumberOfCuts(startingStickLength, cutStickLength);
        }

        /// <summary>
        ///     Method used to ask for cut stick length.
        /// </summary>
        /// <returns>Cut Stick Length.</returns>
        private static decimal AskForCutStickLength()
        {
            Console.WriteLine("What is the cut stick length?");

            var cutStickInput = Console.ReadLine();
            decimal cutStickLength;

            if (!decimal.TryParse(cutStickInput, out cutStickLength))
            {
                Console.WriteLine("Incorrect input, please try again");

                return AskForCutStickLength();
            }

            return cutStickLength;
        }

        /// <summary>
        ///     Method used to ask for starting stick length.
        /// </summary>
        /// <returns>Starting Stick Length.</returns>
        private static decimal AskForStartingStickLength()
        {
            Console.WriteLine("What is the starting stick length?");

            var startingStickInput = Console.ReadLine();
            decimal startingStickLength;

            if (!decimal.TryParse(startingStickInput, out startingStickLength))
            {
                Console.WriteLine("Incorrect input, please try again.");

                return AskForStartingStickLength();
            }

            return startingStickLength;
        }

        /// <summary>
        ///     Method used to determine the minimum number of cuts needed on sticks.
        /// </summary>
        /// <param name="stickLength">Starting Stick Length.</param>
        /// <param name="cutStickLength">Ending Stick Length.</param>
        private static void MinimumNumberOfCuts(decimal stickLength, decimal cutStickLength)
        {
            var cutCount = 0;
            var numberOfSticks = 1;
            var startingStickLength = stickLength;

            while(startingStickLength > cutStickLength)
            {
                startingStickLength /= 2.0m;
                numberOfSticks *= 2;

                cutCount++;
            }

            Console.WriteLine("For a stick with a length of {0} to get sticks under the length of {1} here are the stats:", stickLength, cutStickLength);
            Console.WriteLine("Number of Cuts: {0}", cutCount);
            Console.WriteLine("Number of Sticks: {0}", numberOfSticks);
            Console.WriteLine("Ending Stick Length: {0}", startingStickLength);
        }
    }
}
