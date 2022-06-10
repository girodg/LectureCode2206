using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Day5
    {

        static Random rando = new Random();

        static Dictionary<int,ulong> _fib = new Dictionary<int,ulong>();
        public static void Run()
        {
            _fib.Add(0, 0);
            _fib[1] = 1;

            Stopwatch sw = new Stopwatch();
            for (int N = 0; N < 145; N++)
            {
                sw.Restart();
                ulong fib = Fibonacci2(N);
                sw.Stop();
                long ms = sw.ElapsedMilliseconds;
                Console.Write($"Fibonacci({N}) = {fib}");
                Console.CursorLeft = 50;
                Console.WriteLine($"{ms} ms");
            }



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
            int N2 = 1;
            Counter(N2);
            Console.ResetColor();
        }

        static ulong Fibonacci2(int Steev)
        {
            //exit conditions
            if (_fib.TryGetValue(Steev, out ulong fib))
                return fib;

            fib = Fibonacci2(Steev - 1) + Fibonacci2(Steev - 2);
            _fib[Steev] = fib;
            return fib;
        }

        static long Fibonacci(int N)
        {
            //exit conditions
            if (N == 0) return 0;
            if (N == 1) return 1; 

            long result = Fibonacci(N - 1) + Fibonacci(N - 2);
            return result;
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
