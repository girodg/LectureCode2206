using System;
using System.Collections.Generic;

namespace Day02
{
    internal static class Day02
    {
        public static void Run()
        {
            string[] best = new string[] { "Batman", "Superman?", "Flash" };
            Console.WriteLine(best[1]);
            Console.WriteLine("----------------");
            for (int i = 0; i < best.Length; i++)
            {
                Console.WriteLine(best[i]);//indexer: O(1). constant.
            }
            best[1] = "Aquaman";
            ArrayChallenge();

            // = new  that is creating an instance
            List<string> bestList = new List<string>() { "Batman" };
            bestList.Add("Flash");
            bestList.Add("Wonder Woman");

            ListChallenge();
        }

        static void ListChallenge()
        {
            List<double> grades = new List<double>();
            Random randy = new Random();
            for (int i = 0; i < 10; i++)
            {
                //0.0 - 1.0 like a percentage
                grades.Add(randy.NextDouble() * 101);
            }
        }

        static int Find(string[] names, string itemToFind)
        {
            //Performance: O(N) linear.
            int index = -1;
            int N = names.Length;
            for (int i = 0; i < N; i++)
            {
                if (names[i] == itemToFind)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        static void ArrayChallenge()
        {
            int[] numbers = new int[10];
            Random rando = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rando.Next(100);
            }
            Console.WriteLine("--------NUMBERS--------");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
