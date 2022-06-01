using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine(best[i]);
            }
            best[1] = "Aquaman";
            ArrayChallenge();
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
