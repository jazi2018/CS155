using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Card
    {
        public string Name { get; set; }
        public string Set { get; set; }
        public string Type { get; set; }

        public Card(string name, string set, string type)
        {
            Name = name;
            Set = set;
            Type = type;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}\n{2}", Name, Set, Type);
        }
    }
}
