﻿using System;
using System.Collections.Generic;

namespace Day02
{
    internal static class Day02
    {
        public static void Run()
        {
            string[] best = new string[] { "Batman", "Superman?", "Flash" };
            Console.WriteLine(best[1]);
            Console.WriteLine("----------------");
            for (int i = 0; i < best.Length; i++)
            {
                Console.WriteLine(best[i]);//indexer: O(1). constant.
            }
            best[1] = "Aquaman";
            ArrayChallenge();

            // = new  that is creating an instance
            List<string> bestList = new List<string>();// { "Batman" };
            PrintInfo(bestList);//Count: 0  Capacity: 0
            bestList.Add("Flash");
            PrintInfo(bestList);//Count: 1  Capacity: 0
            bestList.Add("Wonder Woman");
            PrintInfo(bestList);//Count: 2 Capacity:4
            bestList.Add("Batman");
            bestList.Add("Aquaman");
            bestList.Add("Superman");
            PrintInfo(bestList);//Count: 5 Capacity:8
            bestList.Add("Hulk");
            bestList.Add("Spiderman");
            bestList.Add("Green Lantern");
            bestList.Add("Daredevil");
            PrintInfo(bestList);//Count: 9 Capacity:16
            Print(bestList);

            ListChallenge();
        }

        private static void Print(List<string> bestList)
        {
            Console.WriteLine("----------Supers----------");
            //for (int i = 0; i < bestList.Count; i++)
            //{
            //    Console.WriteLine(bestList[i]);
            //}
            foreach (string super in bestList)
            {
                Console.WriteLine(super);
            }
        }

        private static void PrintInfo(List<string> list)
        {
            //Count: # of items added to the list
            //Capacity: length of internal array
            Console.WriteLine($"Count: {list.Count}\tCapacity: {list.Capacity}");
        }

        static void ListChallenge()
        {
            List<double> grades = new List<double>();
            Random randy = new Random();
            for (int i = 0; i < 10; i++)
            {
                //0.0 - 1.0 like a percentage
                grades.Add(randy.NextDouble() * 101);
            }
        }

        static int Find(string[] names, string itemToFind)
        {
            //Performance: O(N) linear.
            int index = -1;
            int N = names.Length;
            for (int i = 0; i < N; i++)
            {
                if (names[i] == itemToFind)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        static void ArrayChallenge()
        {
            int[] numbers = new int[10];
            Random rando = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rando.Next(100);
            }
            Console.WriteLine("--------NUMBERS--------");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
