using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Hello Gotham!");
            int sum = Add(5, 2);
            int n1 = 10, n2 = 32;
            sum = Add(n1, n2);
            PrintMessage();
            string msg = GetMessage();
            PrintMessage(msg);

            int result = 0;
            bool isEven = Add(n1, n2, ref result);
            Console.WriteLine($"{n1} + {n2} = {result}. Is even? {isEven}");
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham.");
        }
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string GetMessage()
        {
            string message = string.Empty;
            Console.Write("Who is the greatest? ");
            message = Console.ReadLine();
            return message;
        }

        static int Add(int num1, int num2)//passed by value (or copied in)
        {
            num1 += 5;
            return num1 + num2;
        }

        //ref - keyword for pass by reference
        static bool Add(int num1, int num2, ref int sum)
        {
            sum = num1 + num2;
            return sum % 2 == 0;
        }

        static void SayHello(string name)
        {
            //$ - interpolated string
            Console.WriteLine($"Hello {name}. I am the hero you need.");
        }
    }
}
