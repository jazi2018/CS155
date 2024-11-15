using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Homework
{
    internal class OgreAlien : Alien
    {
        public OgreAlien(int health, string name) : base(health, name) { }

        override public int GetDamage() { return 6; }
    }
}
