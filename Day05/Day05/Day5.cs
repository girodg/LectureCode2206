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
