using LectureLib;
using System;
using System.Collections.Generic;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
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
            Inventory dufflebag = new Inventory(10, new List<string>());
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
            dufflebag.AddItem("gun");


            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 1000, 1000000);
            int damage = sting.DoDamage();
            Console.WriteLine($"We swing Sting and do {damage} damage to the rat.");


            Console.WriteLine("--------WEAPONRARITY----------");
            foreach (var rarity in Enum.GetValues<WeaponRarity>())
            {
                Console.WriteLine(rarity);
            }
        }
    }
}
