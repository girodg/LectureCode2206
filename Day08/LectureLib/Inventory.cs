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
        private List<string> _items = new List<string>();
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
        public List<string> Items
        {
            get { return _items; }
            private set { _items = value; }
        }
        #endregion

        #region Constructors
        public Inventory(int capacity, List<string> items)
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
        public void AddItem(string item)//hidden parameter called 'this'
        {
            if (Count >= Capactity)
                throw new Exception("Your backpack is full, fool!");

            _items.Add(item);
        }
        #endregion
    }
}
