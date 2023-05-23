using HomeAssignment.SectionB;
using System;
using System.Diagnostics;
using System.Linq;

namespace HomeAssignment
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            /*
            //Section B (Question 1b)
            int[] set = { 3, 34, 4, 12, 5, 2 };
            int sum1 = 9;
            int sum2 = 900;

            bool existsFor9 = SubsetSumProblem.sumExists(set, sum1, set.Length);
            bool existsFor900 = SubsetSumProblem.sumExists(set, sum2, set.Length);

            Console.WriteLine("The expected outputs are:");
            Console.WriteLine("For sum = 9: " + existsFor9);
            Console.WriteLine("For sum = 900: " + existsFor900);
            */

            /*
            //Section B (Question 2b)
            int[][] inputSizes = {
                new int[] { 5, 20 },
                new int[] { 50, 20 },
                new int[] { 500, 20 }
            };

            foreach (int[] inputSize in inputSizes)
            {
                int size = inputSize[0];
                int repetitions = inputSize[1];

                Console.WriteLine("\n************************************************\n" +
                                  "Input Size: " + size);

                long totalTime = 0;
                for (int i = 0; i < repetitions; i++)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    bool exists = IsSumInSubset(size);

                    stopwatch.Stop();
                    long elapsedTicks = stopwatch.ElapsedTicks;
                    totalTime += elapsedTicks;

                    Console.WriteLine($"Iteration {i + 1}: {elapsedTicks} ticks, Exists? {exists}");
                }

                double averageTime = (double)totalTime / repetitions;
                Console.WriteLine("Average Execution Time: " + averageTime + " ticks\n");

            }*/
        }

        public static bool IsSumInSubset(int sizeOfSet)
        {

            //Create a set of unique random integers of size n
            int[] set = new int[sizeOfSet];
            set = Enumerable.Range(0, int.MaxValue).Take(sizeOfSet).ToArray();

            //Generate a random sum value
            int randomSumValue = rand.Next(0, sizeOfSet);

            //Display the set of numbers as a comma-separated string
            //Console.WriteLine("Set:\n" + string.Join(",", set) + "\n");

            //Check if the sum randomValue exists in set
            bool sumExits = SubsetSumProblem.sumExists(set, randomSumValue, set.Length);

            //Check if the required sum exits
            if (sumExits == true)
            {
                //Console.WriteLine("Found a subset of elements which add up to {0}\n\n", randomSumValue);
                return true;
            }
            else
            {
                //Console.WriteLine("No subset of elements which add up to {0} found\n", randomSumValue);
                return false;
            }
        }
    }
}
