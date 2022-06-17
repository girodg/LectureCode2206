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
            //banky = new BankAccount(BankAccountType.Checking, 123456789, 987654321, 10000.50);
            banky = Factory.MakeAcct(BankAccountType.Checking, 123456789, 987654321, 10000.50);
            Console.WriteLine($"My account number: {banky.AccountNumber}");//call the get
            try
            {
                double funds = banky.Withdraw(11000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Inventory backpack = new Inventory(3, new List<FantasyWeapon>());
            Inventory dufflebag = new Inventory(10, new List<FantasyWeapon>());
            try
            {
                backpack.AddItem(WeaponFactory.MakeWeapon(WeaponRarity.Common, 1, 10, 5));
                backpack.AddItem(WeaponFactory.MakeWeapon(WeaponRarity.Uncommon, 10, 100, 50));
                backpack.AddItem(WeaponFactory.MakeWeapon(WeaponRarity.Common, 1, 10, 5));
                backpack.AddItem(WeaponFactory.MakeWeapon(WeaponRarity.Uncommon, 1, 10, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            dufflebag.AddItem(WeaponFactory.MakeWeapon(WeaponRarity.Legendary, 1, 10, 5));
            dufflebag.AddItem(new BowWeapon(5, 10, WeaponRarity.Rare, 20, 75, 200));


            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 1000, 1000000);
            int damage = sting.DoDamage(50);
            damage = sting.DoDamage();
            Console.WriteLine($"We swing Sting and do {damage} damage to the rat.");

            dufflebag.AddItem(sting);
            dufflebag.PrintInventory();
            var bows = dufflebag.Bows();

            FantasyWeapon sword = WeaponFactory.MakeWeapon(WeaponRarity.Common, 1, 10, 10);

            Console.WriteLine("--------WEAPONRARITY----------");
            foreach (var rarity in Enum.GetValues<WeaponRarity>())
            {
                Console.WriteLine(rarity);
            }

            int number = 5;
            long bigNum = number;
            number = (int)bigNum;

            Person alfred = new Person("Alfred Pennyworth", 85);
            Superhero batman = new Superhero("Batman", Superpower.Money, "Bruce Wayne", 35);

            //UPCASTING: going from a derived variable to a base variable
            // ALWAYS SAFE!!
            Person guy = batman;//will this work?? YES!
            guy = alfred;

            alfred.WhoAmI();
            batman.WhoAmI();
            guy = batman;
            guy.WhoAmI();//what will print??

            //DOWNCASTING: going from a base variable to a derived variable
            // NEVER SAFE!!!!!!!!!!
            //ways to make this safe
            //  try-catch (boo!)
            //  as keyword
            //  pattern matching
            try
            {
                Superhero hero = (Superhero)guy;//will this work?? NO! will throw an exception

            }
            catch (Exception)
            {
            }

            Superhero hero2 = guy as Superhero;//if cannot downcast, NULL will be stored in hero2
            if(hero2 != null)
                Console.WriteLine(hero2.Identity);//will throw a null reference exception

            if(guy is Superhero hero3)
                Console.WriteLine(hero3.Identity);
        }
    }
}
