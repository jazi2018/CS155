using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Hmwk1
{
    internal class Person
    {
        private String name;
        public Person() { name = ""; }
        public Person(string theName) { name = theName; }
        public Person(Person obj) { this.SetName(obj.GetName()); }
        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }
        public string ToString() { return this.GetName(); }
        public bool Equals(Object obj) { 
            Person other = obj as Person;
            return name.Equals(other.GetName()); }
    }
}
