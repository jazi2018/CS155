using Microsoft.VisualBasic.FileIO;
using System;

namespace Homework5_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);
            Console.WriteLine("Before reversal:");
            PrintNumbers(numbers);
            Reverse(numbers);
            Console.WriteLine("After reversal:");
            PrintNumbers(numbers);
        }

        static int[] GenerateNumbers(int size)
        {
            Random rnd = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,11);
            }

            return arr;
        }

        static void PrintNumbers(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine("\t" + i);
            }
        }

        static void Reverse(int[] numbers)
        {
            int num_length = numbers.Length;
            for (int i = 0; i < num_length / 2; i++)
            {
                int temp = numbers[i];
                //replacing index i with its opposite
                //i.e. index 0 is replaced with (10 - 0 - 1) = index 9, which is the last idx
                numbers[i] = numbers[num_length - i - 1];
                numbers[numbers.Length - i - 1] = temp;
            }
        }
    }
}
