using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal static class Day06
    {
        public static void Run()
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int index = LinearSearch(ints, 9);
            if(index != -1)
                Console.WriteLine($"9 was found at index {index}.");
            else
                Console.WriteLine("Out of luck, Chuck.");

        }

        static int LinearSearch(List<int> nums, int searchNumber)
        {
            int foundIndex = -1;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == searchNumber)
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }
    }
}
