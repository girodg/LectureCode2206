using System;
using System.Collections.Generic;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 ways to add data:
            //1) initializer -- will throw an exception if the key is already in the dictionary
            //2) .Add -- will throw an exception if the key is already in the dictionary
            //3) [] -- will NOT throw an exception. Will overwrite the value.
            Dictionary<string, float> menu = new Dictionary<string, float>()
            {
                //{ key, value } KeyValuePair
                {"Spaghetti", 5.99F },
                {"Lasagna", 8.99F }
            };
            menu.Add("Ravioli", 9.99F);
            menu.Add("Cheese Pizza", 12.99F);

            menu["Garlic Bread"] = 5.99F;

        }
    }
}
