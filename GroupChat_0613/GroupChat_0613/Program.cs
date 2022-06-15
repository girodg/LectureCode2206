using System;

namespace GroupChat_0613
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordBarCount("Batman", 10);

            int number = ReadInteger("What is your age? ", 1, 115);
            number = ReadInteger("What is the year model of your car? ", 1908, DateTime.Now.Year + 1);

            string name = string.Empty;
            ReadString("What is your character's name? ", ref name);

            string message = "Do you quit? ";
            string[] options = new[] { "1. Yes", "2. No" };
            ReadChoice(message, options, out int selection);

        }
        //ReadInteger - return type
        public static int ReadInteger(string message, int min, int max)
        {
            do
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int result) && result >= min && result <= max)
                    return result;
                Console.WriteLine("That is not a valid number.");
            } while (true);
        }

        //ReadString - ref param
        public static void ReadString(string message, ref string userInput)
        {
            do
            {
                Console.Write(message);
                userInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userInput))
                    break;
                Console.WriteLine("That is not a valid string.");
            } while (true);
        }

        //ReadChoice - out param
        public static void ReadChoice(string message, string[] menuOptions, out int menuSelection)
        {
            //show the menu options
            for (int i = 0; i < menuOptions.Length; i++)
                Console.WriteLine(menuOptions[i]);

            //get the user's menu selection
            menuSelection = ReadInteger(message, 1, menuOptions.Length);
        }

        public static string GetSpeech()
        {
            string text = "This is the speech";
            return text;
        }

        public static void WordBarCount(string word, int count)
        {
            Console.Write(word);
            Console.CursorLeft = 20;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(new string(' ', count));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  {count}");
            Console.ResetColor();
        }
    }
}
