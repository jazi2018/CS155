/// Homework 2		Problem 1
/// File Name: PigLatin.cs
/// @author: Jared Ziv
/// Date:  August 30, 2024
///
/// Problem Statement: Given two strings with first and last names,
/// convert both into their pig latin equivalents and concatenate
/// into one string. Output the final string.
/// 
/// 
/// Overall Plan:
/// 1) Create ToPigLatin function
///     a) Take string input, create substring from idx 1
///     b) ToUpper(string[0]), concatenate to front of substring
///     c) Concatenate "ay" to end of substring
///     d) Return substring
/// 2) ToPigLatin() the first and last strings
/// 3) Concatenate first and last
/// 4) Console.WriteLine() the concatenated string
/// 

using System;

namespace Homework2_Part1
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            string first = "jared";
            string last = "ziv";

            first = ToPigLatin(first);
            last = ToPigLatin(last);

            string combined_name = first + " " + last;
            Console.WriteLine(combined_name);
        }

        static string ToPigLatin(string word)
        {
            string pl_word = word.Substring(1); //copies the string, but ignoring the first letter
            pl_word += word[0]; //take first letter of word and concatenate to end of substring
            pl_word += "ay"; //add ay to the end to finalize our word
            pl_word = Char.ToUpper(pl_word[0]) + pl_word.Substring(1); //capitalizes the first letter
            return pl_word;
        }
    }
}