using LectureLib;
using System;
using System.Collections.Generic;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount banky; //null. reference type variable.

            //create an instance of BankAccount
            //banky = new BankAccount();//calling the default constructor
            banky = new BankAccount(BankAccountType.Checking, 123456789, 987654321, 10000.50);
            Console.WriteLine($"My account number: {banky.AccountNumber}");//call the get
            try
            {
                double funds = banky.Withdraw(11000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Inventory backpack = new Inventory(3, new List<string>());
            try
            {
                backpack.AddItem("map");
                backpack.AddItem("shovel");
                backpack.AddItem("spear");
                backpack.AddItem("gun");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
