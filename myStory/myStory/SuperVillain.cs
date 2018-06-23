using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperVillain : SuperHuman
    {
        public int _hitPoint { get; set; }
        public string _superWeapon { get; set; }
        public string _villainName { get; set; }

        public SuperVillain(string name, int age, int strength, string weapon) : base(name, age)
        {
            _humanName = name;
            _humanAge = age;
            _hitPoint = strength;
            _superWeapon = weapon;
         
        }
    }
}
