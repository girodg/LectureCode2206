using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day04
{
    enum Superpower
    {
        Speed, Invisibility, Strength, Money, Swimming, Flying, Swinging
    }
    class Superhero
    {
        public string Name { get; set; }
        public string SecretIdentity { get; set; }
        public Superpower Power { get; set; }
    }

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
            Serialize(filePath);
            Deserialize(filePath);
        }

        private static void Deserialize(string filePath)
        {
            //change the extension to .json
            filePath = Path.ChangeExtension(filePath, ".json");

            //check if the file is there
            if (File.Exists(filePath))
            {
                string superData = File.ReadAllText(filePath);
                //deserialize
                try
                {
                    List<Superhero> team = JsonConvert.DeserializeObject<List<Superhero>>(superData);

                    foreach (var super in team)
                    {
                        Console.WriteLine($"Hi. I am {super.Name} ({super.SecretIdentity}). I am good at {super.Power}.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"{filePath} is the incorrect format.");
                }            
            }
            else
                Console.WriteLine($"{filePath} does not exists!");
        }

        private static void Serialize(string filePath)
        {
            //change the extension to .json
            filePath = Path.ChangeExtension(filePath, ".json");

            List<Superhero> heroes = new List<Superhero>();
            heroes.Add(new Superhero() { Name = "Batman", SecretIdentity = "Bruce Wayne", Power = Superpower.Money });
            heroes.Add(new Superhero() { Name = "Flash", SecretIdentity = "Barry Allen", Power = Superpower.Speed });
            heroes.Add(new Superhero() { Name = "Aquaman", SecretIdentity = "Arthur Curry", Power = Superpower.Swimming });
            heroes.Add(new Superhero() { Name = "Wonder Woman", SecretIdentity = "Diana Prince", Power = Superpower.Strength });
            heroes.Add(new Superhero() { Name = "Spiderman", SecretIdentity = "Peter Parker", Power = Superpower.Swinging});
            
            //serialize the list to a file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                //add using Newtonsoft.Json; to the top
                using (JsonTextWriter jsonText = new JsonTextWriter(sw))
                {
                    jsonText.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jsonText, heroes);
                }
            }//
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
