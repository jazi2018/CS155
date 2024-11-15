using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Homework
{
    internal class SnakeAlien : Alien
    {
        public SnakeAlien(int health, string name) : base(health, name) { }

        //overriding alien base class
        override public int GetDamage() { return 10; }
    }
}
