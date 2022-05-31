using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class Day01
    {
        internal static void Run()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Hello Gotham!");
            int sum = Add(5, 2);
            int n1 = 10, n2 = 32;
            sum = Add(n1, n2);
            PrintMessage();
            string msg = GetMessage();
            PrintMessage(msg);//without timestamp
            Timestamp(ref msg);
            PrintMessage(msg);//with timestamp
            PostFix(msg, 99);
            PostFix(msg);

            int result = 0;
            bool isEven = Add(n1, n2, ref result);
            Console.WriteLine($"{n1} + {n2} = {result}. Is even? {isEven}");

            string nmStr = "5";
            bool isGOod = IntTryParse(nmStr, out int number);

            MyFavoriteNumber(out int favorite);
            Console.WriteLine($"Your favorite number is {favorite}. Weird.");
        }


        static string PostFix(string msg, int num = 1)
        {
            return msg + num;
        }

        static void MyFavoriteNumber(out int myFave)
        {
            Console.Write("What is your favorite number? ");
            string faveString = Console.ReadLine();
            //if (!int.TryParse(faveString, out myFave))
            //{
            //    Console.WriteLine("How hard is this, Aquaman?");
            //}
            try
            {
                myFave = int.Parse(faveString);
            }
            catch (Exception)
            {
                myFave = 0;
                Console.WriteLine("How hard is this, Aquaman?");
            }
        }

        static bool IntTryParse(string numberStr, out int number)
        {
            bool isNumber = false;
            try
            {
                number = int.Parse(numberStr);
                isNumber = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                number = 0;
            }
            return isNumber;
        }

        static void Timestamp(ref string message)
        {
            message = $"{DateTime.Now}: {message}";
        }

        //static void PrintMessage()
        //{
        //    Console.WriteLine("Hello Gotham.");
        //}
        static void PrintMessage(string message = "Hello Gotham.")
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
