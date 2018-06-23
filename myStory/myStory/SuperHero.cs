using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHero : SuperHuman
    {
        public int _hitPoint { get; set; }
        public string _superPower { get; set; }

        public SuperHero(string name, int age, string power, int strength, string weapon) : base(name, age)
        {
            _humanName = name;
            _humanAge = age; 
            _superPower = power;
            _hitPoint = strength;
        }
    }
}
