using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Lab1
{
    internal class Pizza
    {
        private static string[] sizes = { "small", "medium", "large" };
        private static int[] costs = { 10, 12, 14 };
        private int _size;
        private int _cheese_toppings;
        private int _pepperoni_toppings;
        private int _ham_toppings;

        public Pizza()
        {
            _size = 0;
            _cheese_toppings = 0;
            _pepperoni_toppings = 0;
            _ham_toppings = 0;
        }

        public Pizza(int size, int cheese_toppings, int peperoni_toppings, int ham_toppings)
        {
            if (size >= 0 && size <= 3)
            {
                _size = size;
            }
            else
            {
                _size = 0;
            }
            _cheese_toppings = cheese_toppings;
            _pepperoni_toppings = peperoni_toppings;
            _ham_toppings = ham_toppings;

        }

        public string getSize()
        {
            return sizes[_size];
        }
        //set size for string passed. returns int for success or failure
        public int setSize(string size)
        {
            switch (size.ToLower())
            {
                case "small":
                    _size = 0;
                    break;
                case "medium":
                    _size = 1;
                    break;
                case "large":
                    _size = 2;
                    break;
                default:
                    //report failure
                    return -1;
            }
            //report success
            return 1;
        }

        //set size for int passed. bound between 0 and 2 (inclusive)
        public void setSize(int size)
        {
            if (size < 0)
            {
                _size = 0;
            }
            else if (size > 2)
            {
                _size = 2;
            }

            _size = size;
        }
        public int CheeseToppings { get { return _cheese_toppings; } set { _cheese_toppings = value; } }
        public int PepperoniToppings { get { return _pepperoni_toppings; } set { _pepperoni_toppings = value; } }
        public int HamToppings { get { return _ham_toppings; } set { _ham_toppings = value; } }
        public int CalculateCost()
        {
            //initialize cost variable based on size of pizza
            int cost = costs[_size];
            //each topping is an extra 2
            cost += (_cheese_toppings + _pepperoni_toppings + _ham_toppings) * 2;

            return cost;
        }
        public string ToString()
        {
            return String.Format("{0} pizza with {1} cheese, {2} pepperoni and {3} ham toppings for ${4}",
                                 sizes[_size], _cheese_toppings, _pepperoni_toppings, _ham_toppings,
                                 CalculateCost());
        }
    }
}
