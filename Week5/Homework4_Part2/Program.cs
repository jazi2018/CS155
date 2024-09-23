using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TOSSES = 8;
            int toss_counter = 0, h_count = 0, t_count = 0;

            char input;

            Console.WriteLine("For each coin toss, enter either 'h' for heads or 't' for tails");
            while (toss_counter < TOSSES)
            {
                Console.Write("\tToss " + (toss_counter + 1) + ": ");
                input = Console.ReadKey().KeyChar;
                if (Char.ToLower(input) == 'h')
                {
                    h_count++;
                }
                else if (Char.ToLower(input) == 't')
                {
                    t_count++;
                }
                toss_counter++;
                Console.Write('\n');
            }

            Console.WriteLine("Heads: {0} \nTails: {1}", h_count, t_count);
            Console.WriteLine("Percent heads: " + ((double)h_count / toss_counter) * 100);
            Console.WriteLine("Percent tails: " + ((double)t_count / toss_counter) * 100);
        }
    }
}