using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("it-IT");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("it-IT");
            //3 ways to add data:
            //1) initializer -- will throw an exception if the key is already in the dictionary
            //2) .Add -- will throw an exception if the key is already in the dictionary
            //3) [] -- will NOT throw an exception. Will overwrite the value.
            Dictionary<string, float> menu = new Dictionary<string, float>()
            {
                //{ key, value } KeyValuePair
                {"Spaghetti", 5.99F },
                {"Lasagna", 8.99F }
            };
            menu.Add("Ravioli", 9.99F);
            menu.Add("Cheese Pizza", 12.99F);

            menu["Garlic Bread"] = 5.99F;
            PrintMenu(menu);

            PressAnyKey();

            Dictionary<string, double> pg2 = FillDictionary();
            PrintGrades(pg2);

        }

        private static void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void PrintGrades(Dictionary<string, double> course)
        {
            Console.Clear();
            Console.WriteLine("----------GRADES---------");
            foreach (KeyValuePair<string, double> student in course)
            {
                double grade = student.Value;
                if (grade < 59.5) Console.BackgroundColor = ConsoleColor.Red;
                else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.Green;

                Console.Write($"{student.Value,7:N2}");
                Console.ResetColor();
                Console.WriteLine($" {student.Key}");

            }
        }

        private static void PrintMenu(Dictionary<string, float> menu)
        {
            Console.WriteLine("Welcome to Mario's Super Italian Restaurante");
            foreach (KeyValuePair<string,float> item in menu)
            {
                //Key, Value
                Console.WriteLine($"{item.Value,9:C2} {item.Key}");
            }
        }

        private static Dictionary<string,double> FillDictionary()
        {
            Dictionary<string, double> course = new Dictionary<string, double>();
            course.Add("Bala", GetGrade());
            course.Add("Emilio", GetGrade());
            course.Add("Davis", GetGrade());
            course.Add("Jason", GetGrade());
            course.Add("Roberto", GetGrade());
            course.Add("Nic", GetGrade());
            course.Add("Aoife", GetGrade());
            course.Add("Forrest", GetGrade());
            course.Add("Ray", GetGrade());
            course.Add("Bryan", GetGrade());
            course.Add("Eric", GetGrade());
            course.Add("Alexis", GetGrade());
            course.Add("Corbin", GetGrade());
            course.Add("Derek", GetGrade());
            course.Add("Drake", GetGrade());
            course.Add("Gabriel", GetGrade());
            course["Ian"] = GetGrade();
            return course;
        }

        static Random _rando = new Random();
        private static double GetGrade()
        {
            return _rando.NextDouble() * 100;
        }
    }
}
