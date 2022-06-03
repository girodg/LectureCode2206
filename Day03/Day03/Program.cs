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

            Dice();
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

            string menuItem = "Garlic Bread";
            bool wasRemoved = menu.Remove(menuItem);
            if (wasRemoved) 
                Console.WriteLine($"{menuItem} forever deleted! Yeah!");
            else 
                Console.WriteLine($"{menuItem} is nowhere to be found.");

            menuItem = "Chicken nuggets"; 
            wasRemoved = menu.Remove(menuItem);
            if (wasRemoved)
                Console.WriteLine($"{menuItem} forever deleted! Yeah!");
            else
                Console.WriteLine($"{menuItem} is nowhere to be found.");

            menuItem = "Ravioli";
            //float price = menu["Burger"];//will throw an exception!
            if (menu.TryGetValue(menuItem, out float price))
            {
                float newPrice = price + 4;
                menu[menuItem] = newPrice;//update the value in the dictionary
                Console.WriteLine($"{menuItem} was {price:C2} but is now {newPrice:C2}. Thanks Putin!");
            }
            else
                Console.WriteLine($"{menuItem} not found. go away.");

            PressAnyKey();

            Dictionary<string, double> pg2 = FillDictionary();
            PrintGrades(pg2);
            PressAnyKey();
            DropStudent(pg2);
            CurveStudent(pg2);
        }

        enum DiceFace
        {
            One, Two, Three, Four, Five, Six
        }
        private static void Dice()
        {
            //\u defines a unicode value
            char[] symbols = new char[]
            {
                '\u2680', '\u2681', '\u2682', '\u2683', '\u2684', '\u2685'
            };
            foreach (DiceFace face in Enum.GetValues(typeof(DiceFace)))
            {
                Console.Write(symbols[(int)face]);//use the enum as an index into the symbol array
            }
            Console.WriteLine();
            PressAnyKey();
            //store the counts of rolling each dice face
            Dictionary<DiceFace, int> throws = new();
            for (int i = 0; i < 100; i++)
            {
                DiceFace diceThrow = (DiceFace)_rando.Next(6);
                //if diceThrow is already in the dictionary, increment the count
                //else add the diceThrow to the dictionary
                if (throws.TryGetValue(diceThrow, out int count))
                    throws[diceThrow] = count + 1;
                else
                    throws[diceThrow] = 1;//throws.Add(diceThrow,1);

                Console.Write(symbols[(int)diceThrow]);
            }
            Console.WriteLine();

            foreach (KeyValuePair<DiceFace,int> dice in throws)
            {
                //dice.Key is the DiceFace
                //dice.Value is the count for that DiceFace
                Console.WriteLine($"{symbols[(int)dice.Key]} : {dice.Value}");
            }
            Console.ReadKey();
        }

        private static void CurveStudent(Dictionary<string, double> course)
        {
            do
            {
                Console.Write("Who should we curve? ");
                string student = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(student)) break;

                bool wasFound = course.TryGetValue(student, out double grade);
                if (wasFound)
                {
                    //ternary operator
                    grade = (grade > 95) ? 100 : grade + 5;
                    course[student] = grade;//overwrite with the new grade
                    Console.WriteLine($"{student}'s grade was updated to {grade}.");
                }
                else
                    Console.WriteLine($"{student} is nowhere to be found.");
                PressAnyKey();
                PrintGrades(course);
            } while (true);
        }

        private static void DropStudent(Dictionary<string, double> course)
        {
            do
            {
                Console.Write("Who should be dropped? ");
                string student = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(student)) break;
                bool wasRemoved = course.Remove(student);
                if (wasRemoved)
                    Console.WriteLine($"{student} was kicked!");
                else
                    Console.WriteLine($"{student} is nowhere to be found.");
                PressAnyKey();
                PrintGrades(course);
            } while (true);
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
