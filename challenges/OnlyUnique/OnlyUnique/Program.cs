using Hashtables.Classes;
using System;

namespace OnlyUnique
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string test = "abcd efghi jklmnop 12345";
            string test2 = "abc bad";

            Console.WriteLine(Unique(test));
            Console.WriteLine(Unique(test2));
        }

        /// <summary>
        /// Take in a string and check if it contains only unique characters
        /// </summary>
        /// <param name="input">string to test</param>
        /// <returns>true or false</returns>
        public static bool Unique(string input)
        {
            Hashtable ht = new Hashtable();

            string[] allWords = input.Split(" ");
            string merged = string.Join("", allWords);

            for (int i = 0; i < merged.Length; i++)
            {
                string letter = merged[i].ToString().ToLower();

                if (ht.Contains(letter))
                    return false;
                else
                    ht.Add(letter, "");
            }

            return true;
        }
    }
}
