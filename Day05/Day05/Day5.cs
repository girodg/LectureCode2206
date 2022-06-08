using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Day5
    {

        static Random rando = new Random();
        public static void Run()
        {
            long result = Factorial(5);
            Console.WriteLine($"5! = {result}");
            Console.ReadKey();
            while (true)
            {
                if (rando.Next(100) == 50) break;
            }
            RandoRecursive();

            Console.WriteLine("---------iterative loop---------");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------recursive loop---------");
            int N = 1;
            Counter(N);
            Console.ResetColor();
        }

        static long Factorial(int N)
        {
            if (N == 1) return 1; //exit condition
            long result = N * Factorial(N - 1);//5 * 4!
            return result;
        }

        private static void Counter(int N)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(N);
            if (N < 100)
                Counter(N + 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(N);
        }

        static void RandoRecursive()
        {
            if (rando.Next(100) == 50)
                return;//break
            RandoRecursive();
        }
    }
}
