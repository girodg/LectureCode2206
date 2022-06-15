﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureLib
{
    public enum Superpower
    {
        Speed, Flight, Strength, Money
    }
    //Derived : Base
    public class Superhero : Person //set up the inheritance
    {
        public string Identity { get; set; }
        public Superpower Power { get; set; }
        
        public Superhero(string identity, Superpower power, string name, int age) : base(name, age)
        {
            Identity = identity;
            Power = power;
        }
    }
}
