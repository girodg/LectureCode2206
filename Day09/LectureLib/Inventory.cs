using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureLib
{
    public class Inventory
    {
        static int NumberOfBackpacks = 0;//tied to the class
        #region Fields
        private int _capacity = 0;//tied to the instance b/c it's non-static
        private List<FantasyWeapon> _items = new List<FantasyWeapon>();
        #endregion

        #region Properties
        public int Capactity { 
            get { return _capacity; }
            set
            {
                if (value > 0) _capacity = value;
            }
        }
        public int Count
        {
            get { return _items.Count; }
        }
        public List<FantasyWeapon> Items
        {
            get { return _items; }
            private set { _items = value; }
        }
        #endregion

        #region Constructors
        public Inventory(int capacity, List<FantasyWeapon> items)
        {
            NumberOfBackpacks++;
            int localVar = 5;//local to this method only
            _capacity = capacity;
            Capactity = capacity;
            Items = items.ToList();//clone the list
        }
        #endregion

        #region Methods
        public static void HowManyBackpacks()//there is no 'this' param
        {
            Console.WriteLine($"We've created {NumberOfBackpacks} backpacks.");
        }

        //every instance method has a hidden param called 'this'
        //'this' refers to the instance it was called
        //Inventory this

        //NON-static, instance method
        public void AddItem(FantasyWeapon item)//hidden parameter called 'this'
        {
            if (Count >= Capactity)
                throw new Exception("Your backpack is full, fool!");

            _items.Add(item);
        }

        public void PrintInventory()
        {
            Console.WriteLine($"\n-------------INVENTORY ({Count})------------");
            foreach (FantasyWeapon item in _items)
            {
                Console.WriteLine(item.Display());
                //Console.WriteLine($"I have a level {item.Level} {item.Rarity} weapon {item.GetSymbol()} that can do {item.MaxDamage} damage. And it cost {item.Cost}.");
                //if(item is BowWeapon bow)
                //    Console.WriteLine($"\t and it has {bow.ArrowCount} arrows with a capacity to hold {bow.ArrowCapacity} arrows.");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
