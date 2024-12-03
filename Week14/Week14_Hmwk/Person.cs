using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_Hmwk
{
    internal class Person
    {
        //member variables
        private string name;
        private int age;
        private double height;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        //full constructor
        public Person(string name, int age, double height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }
    }
}
