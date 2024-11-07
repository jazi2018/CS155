using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Hmwk1
{
    internal class Truck : Vehicle
    {
        private double load;
        private int tow;

        public double Load { get; set; }
        public int Tow { get; set; }

        public Truck() { Load = 0; Tow = 0; }
        public Truck(Manufacturer manufacturer, int cylinders, Person owner, double load, int tow)
        : base(manufacturer, cylinders, owner)
        {
            Load = load;
            Tow = tow;
        }
        public string ToString()
        {
            return String.Format("{0}. It can bear a load of {1} ton(s) and tow {2} lbs.", base.ToString(), Load, Tow);
        }
        public bool Equals(Truck other)
        {
            return base.Equals(other) && Load == other.Load && Tow == other.Tow;
        }
    }
}
