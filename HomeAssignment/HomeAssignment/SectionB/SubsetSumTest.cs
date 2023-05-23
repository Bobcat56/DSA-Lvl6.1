using System;
using System.Diagnostics;
using System.Linq;

namespace HomeAssignment.SectionB
{
    class Program
    {

        static Random rand = new Random();

        static void SubMain(string[] args)
        {
            //Determine the input size i.e. n
            int inputSize = 10;

            //Check if a random sum value exits in the random set
            IsSumInSubset(inputSize);

            Console.ReadKey();

        }


        public static bool IsSumInSubset(int sizeOfSet)
        {

            //Create a set of unique random integers of size n
            int[] set = new int[sizeOfSet];
            set = Enumerable.Range(0, int.MaxValue).Take(sizeOfSet).ToArray();

            //Generate a random sum value
            int randomSumValue = rand.Next(0, sizeOfSet);

            //Display the set of numbers as a comma-separated string
            Console.WriteLine("Set:\n" + string.Join(",", set) + "\n");

            //Check if the sum randomValue exists in set
            bool sumExits = SubsetSumProblem.sumExists(set, randomSumValue, set.Length);

            //Check if the required sum exits
            if (sumExits == true)
            {
                Console.WriteLine("Found a subset of elements which add up to {0}\n\n", randomSumValue);
                return true;
            }
            else
            {
                Console.WriteLine("No subset of elements which add up to {0} found\n", randomSumValue);
                return false;
            }
        }
    }
}

