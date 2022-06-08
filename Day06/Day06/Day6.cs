using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal static class Day6
    {
        public static void Run()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            Swap(nums, 2, 3);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }

            Console.WriteLine();
            string s1 = "Batman", s2 = "Batmen";
            // -1: less than
            //  0: equal to
            //  1: greater than
            int compResult = s1.CompareTo(s2);
            if (compResult == 0) Console.WriteLine($"{s1} EQUALS {s2}");
            else if(compResult == -1) Console.WriteLine($"{s1} LESS THAN {s2}");
            else if (compResult == 1) Console.WriteLine($"{s1} GREATER THAN {s2}");
        }

        private static void Swap(int[] nums, int ndx1, int ndx2)
        {
            //int temp = nums[ndx1];
            //nums[ndx1] = nums[ndx2];
            //nums[ndx2] = temp;
            (nums[ndx2], nums[ndx1]) = (nums[ndx1], nums[ndx2]);
        }
    }
}
