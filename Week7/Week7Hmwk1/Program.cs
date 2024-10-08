using System;

namespace Week7Hmwk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //driver program

            //initialize objects
            Counter count1 = new Counter();
            Counter count2 = new Counter();

            //start menu loop
            Console.WriteLine("Please select one of the following options.");
            while (true)
            {
                Console.WriteLine("1. getCount\n" +
                                "2. increment\n" +
                                "3. decrement\n" +
                                "4. ToString\n" +
                                "5. Equals");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("count1 or count2?");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            switch (input2)
                            {
                                case 1: Console.WriteLine(count1.getCount()); break;
                                case 2: Console.WriteLine(count2.getCount()); break;
                                default: Console.WriteLine("Invalid input"); break;
                            }
                            break;
                        case 2:
                            switch (input2)
                            {
                                case 1: count1.increment(); break;
                                case 2: count2.increment(); break;
                                default: Console.WriteLine("Invalid input"); break;
                            }
                            break;
                        case 3:
                            switch (input2)
                            {
                                case 1: count1.decrement(); break;
                                case 2: count2.decrement(); break;
                                default: Console.WriteLine("Invalid input"); break;
                            }
                            break;
                        case 4:
                            switch (input2)
                            {
                                case 1: Console.WriteLine(count1.ToString()); break;
                                case 2: Console.WriteLine(count2.ToString()); break;
                                default: Console.WriteLine("Invalid input"); break;
                            }
                            break;
                        case 5:
                            switch (input2)
                            {
                                case 1: Console.WriteLine(count1.Equals(count2)); break;
                                case 2: Console.WriteLine(count2.Equals(count1)); break;
                                default: Console.WriteLine("Invalid input"); break;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: please enter a valid integer selection");
                }
            }
        }
    }
}
