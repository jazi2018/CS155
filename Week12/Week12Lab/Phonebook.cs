using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Lab
{
    internal class Phonebook
    {
        //key = first name, value = phone number (formatted (###) ### - ####)
        private Dictionary<string, string> book;

        public Phonebook()
        {
            //initialize book
            book = new Dictionary<string, string>();
        }

        public void Lookup(string name)
        {
            if (book.ContainsKey(name))
            {
                Console.WriteLine("{0}: {1}", name, book[name]);
            }
            else
            {
                //name does not have a number in the phonebook
                Console.WriteLine("No entry found for {0} in this phonebook.", name);
            }
        }

        public void Add(string name, string number)
        {
            if (!book.ContainsKey(name))
            {
                book.Add(name, number);
                Console.WriteLine("Added {0} with phone number {1}.", name, number);
            }
            else
            {
                Console.WriteLine("{0} already has an entry in this phonebook.", name);
            }
        }

        public void Remove(string name)
        {
            if (book.ContainsKey(name))
            {
                book.Remove(name);
                Console.WriteLine("{0} has been removed from this phonebook.", name);
            }
            else
            {
                Console.WriteLine("No entry found for {0} in this phonebook.", name);
            }
        }

        public void ListAll()
        {
            Console.WriteLine("Displaying {0} entries:", book.Count);
            foreach (KeyValuePair<string, string> obj in book)
            {
                Console.WriteLine("{0}: {1}", obj.Key, obj.Value);
            }
        }

        public void Clear()
        {
            Console.WriteLine("Removing {0} entries from this phonebook.", book.Count);
            book.Clear();
        }
    }
}
