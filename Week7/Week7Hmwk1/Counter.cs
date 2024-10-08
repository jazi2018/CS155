using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Hmwk1
{
    public class Counter
    {
        private int count;
        
        public Counter() { count = 0; }
        //specifications say no setters, i am assuming that means no parameterized
        //constructor, but just in case this is the code i would use
        //public Counter(int count)
        //{
        //    this.count = (count >= 0) ? count : 0;
        //}

        public int getCount() //getter
        {
            return this.count;
        }
        
        public void zeroCount() { this.count = 0; }

        public void increment() { this.count++; }
        public void decrement()
        {
            //if decrement would bring below zero, set to zero instead
            this.count = (this.count - 1 >= 0) ? this.count - 1 : 0;
        }

        public String ToString()
        {
            return ("Current count is: " + getCount());
        }
        public bool Equals(Counter other)
        {
            return this.count == other.count;
        }
    }
}
