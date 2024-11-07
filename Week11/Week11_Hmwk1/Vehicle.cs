using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Hmwk1
{
    public enum Manufacturer
    {
        Toyota, Honda, Chevrolet, Ford, BMW, Lexus, Subaru, Volvo, Nissan
    }
    internal class Vehicle
    {
        private Manufacturer manufacturer;
        private int cylinders;
        private Person owner;

        public Manufacturer Manufacturer { get; set; }
        public int Cylinders { get; set; }
        public Person Owner { get; set; }

        public Vehicle() //default
        {
            Manufacturer = 0;
            Cylinders = 0;
            Owner = new Person();
        }
        public Vehicle(Manufacturer manufacturer, int cylinders, Person owner)
        {
            Manufacturer = manufacturer;
            Cylinders = cylinders;
            Owner = owner;
        }
        public string ToString()
        {
            return String.Format("{0} cylinder engine manufactured by {1} and owned by {2}", Cylinders, Manufacturer, Owner.ToString());
        }
        public bool Equals(Vehicle other)
        {
            return Manufacturer == other.Manufacturer && Cylinders == other.Cylinders && Owner == other.Owner;
        }
    }
}
