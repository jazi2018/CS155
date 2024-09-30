using System;

namespace Week6_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 101);

            int guesses = 0;
            Console.WriteLine("Guess the number. I will tell you if it's higher or lower.");
            while (true)
            {
                int guess = Int32.Parse(Console.ReadLine());
                guesses++;
                if (guess > num)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < num)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    //just to make this gramatically correct
                    if (guesses == 1)
                    {
                        Console.WriteLine("You got it in {0} guess!", guesses);
                    }
                    else
                    {
                        Console.WriteLine("You got it in {0} guesses!", guesses);
                    }
                    break;
                }
            }
        }
    }
}
