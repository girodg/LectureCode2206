using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureLib
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Time to eat {food}. Nom nom.");
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine($"Hi. I am {Name} and I am {Age} years old.");
        }
    }
}
