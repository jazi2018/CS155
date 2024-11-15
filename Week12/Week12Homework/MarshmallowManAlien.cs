using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Homework
{
    internal class MarshmallowManAlien : Alien
    {
        public MarshmallowManAlien(int health, string name) : base(health, name) { }

        override public int GetDamage() { return 1; }
    }
}
