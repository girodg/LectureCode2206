using System;
using System.IO;
using System.Text;

namespace Day04
{
    internal static class Day4
    {
        public static void Run()
        {
            string filePath = @"C:\temp\2206\HighScores.txt";
            char delimiter = '^';
            //1. open the file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                //2. Write to the file
                sw.Write("Batman");
                sw.Write(delimiter);
                sw.Write(10000000);
                sw.Write(delimiter);
                sw.Write("Aquaman");
                sw.Write(delimiter);
                sw.Write(-50);
                sw.Write(delimiter);
                sw.Write(true);
                sw.Write(delimiter);
                sw.Write(57.3);
                sw.Write(delimiter);
                sw.Write(12);
            }//3. Close the file!

            ReadData(filePath);
        }

        private static void ReadData(string filePath)
        {
            char delimiter = '^';
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);

                string[] data = line.Split(delimiter);
                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }
                //Console.WriteLine(data[0]);
                //int score = int.Parse(data[1]);
            }
            // ALTERNATE WAY of reading
            //...use File.ReadAllText
            //
            string lineData = File.ReadAllText(filePath); //does all 3 steps: open, read, close
            string[] data2 = lineData.Split(delimiter);
            foreach (var item in data2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
