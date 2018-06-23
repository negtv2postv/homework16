using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHuman
    {
        public string _humanName { get; set; }
        public int _humanAge { get; set; }
        
        public SuperHuman(string name, int age)
        {
            _humanName = name;
            _humanAge = age;
        }
    }
}
