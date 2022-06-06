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
        }
    }
}
