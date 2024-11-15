using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Homework
{
    internal class Alien
    {
        private int health; //0 = dead, 100 = full
        private string name;
        public Alien(int health, string name)
        {
            this.health = health;
            this.name = name;
        }

        //virtual so that derived classes can override the function and
        //utilize the overriden version when called from AlienPack
        virtual public int GetDamage() { return 0; }
    }
}
