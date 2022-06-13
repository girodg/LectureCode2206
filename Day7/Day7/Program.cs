using LectureLib;
using System;

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
        }
    }
}
