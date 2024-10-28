using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Homework1
{
    internal class Duelist
    {
        private string _name;
        private double _accuracy;
        private bool _is_alive;
        private Random random;

        public Duelist(string name, double accuracy)
        {
            _name = name;
            _accuracy = accuracy;
            IsAlive = true;
            random = new Random();
        }

        public string Name { get { return _name; } }
        public double Accuracy { get { return _accuracy; } }
        public bool IsAlive { get; set; }

        public void ShootAtTarget(Duelist target)
        {
            //hits if below accuracy value (like a cutoff)
            bool hit = random.NextDouble() <= Accuracy;
            if (hit)
            {
                target.IsAlive = false;
            }
        }
        public void Reset()
        {
            IsAlive = true;
        }
        public string ToString()
        {
            return _name;
        }
    }
}
