using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Homework1
{
    internal class Odometer
    {
        private double _miles;
        private double _gallons;

        //default constructor
        public Odometer() { _miles = 0; _gallons = 0; }
        //parameterized constructor
        public Odometer(double miles, double gallons)
        { _miles = miles; _gallons = gallons; }
        
        public double Miles { get { return _miles; }
                              //prevent miles from being negative
                              set { _miles = value < 0 ? 0 : value; } }
        public double Gallons { get { return _gallons; }
                                //prevent gallons from being negative
                                set { _gallons = value < 0 ? 0 : value; } }

        public void Reset() { _miles = 0; _gallons = 0; }
        public void Add(double miles, double gallons)
        { _miles += miles; _gallons += gallons; }
        public double CalcMPG()
        {
            if (_gallons <= 0) return 0;
            else return _miles / _gallons;
        }
        public string ToString()
        {
            return String.Format("Driven {0:0.00} miles and consumed {1:0.00} gallons of fuel.\n" +
                                 "Total MPG: {2:0.00}", _miles, _gallons, CalcMPG());
        }
    }
}
