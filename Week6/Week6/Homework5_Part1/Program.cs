using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int size = 10;
            int[] arr = new int[size];

            //fill array with random numbers and print
            Console.WriteLine("INITIAL ARRAY:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = generator.Next(15);
                Console.WriteLine(arr[i]);
            }

            //create second array variable
            int[] arr_copy = new int[arr.Length];

            //copy first array into second array and print
            Console.WriteLine("COPIED ARRAY:");
            for (int i = 0; i < arr_copy.Length; i++)
            {
                arr_copy[i] = arr[i];
                Console.WriteLine(arr_copy[i]);
            }
        }
    }
}