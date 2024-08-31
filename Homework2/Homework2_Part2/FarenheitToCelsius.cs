/// Homework 2		Problem 2
/// File Name: FarenheitToCelsius.cs
/// @author: Jared Ziv
/// Date:  August 30, 2024
///
/// Problem Statement: Accept user input for a temperature in
/// degrees Farenheit. Convert to celsius and print new value.
/// Include fractional part to one decimal point.
/// 
/// 
/// Overall Plan:
/// 1) Prompt and accept user input into an int
/// 2) Create a ToCelsius() function that accepts an int
///     a) Subtract 32 from original temp, assign to new double variable
///     b) Multiply new temp by 5
///     c) Divide by 9
///     d) Use Math.Round() to round result to one decimal
///     e) Return final value
/// 3) Print value returned from ToCelsius()
/// 

using System;

namespace Homework2_Part2
{
    class FarenheitToCelsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in Farenheit:");
            int f_temp = int.Parse(Console.ReadLine());
            double c_temp = ToCelsius(f_temp);
            Console.WriteLine("{0} degrees Farenheit = {1} degrees Celsius", f_temp, c_temp);
        }

        static double ToCelsius(int f_temp)
        {
            double c_temp = f_temp - 32;
            c_temp *= 5;
            c_temp /= 9;
            c_temp = Math.Round(c_temp, 1);
            return c_temp;
        }
    }
}