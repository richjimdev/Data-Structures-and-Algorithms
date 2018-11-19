using Hashtables.Classes;
using System;

namespace OnlyUnique
{
    public class Program
    {
        public static void Main(string[] args)
        {


        }

        /// <summary>
        /// Take in a string and check if it contains only unique characters
        /// </summary>
        /// <param name="input">string to test</param>
        /// <returns>true or false</returns>
        public static bool Unique(string input)
        {
            Hashtable ht = new Hashtable();

            string merged = input.Split(" ").ToString();

            for (int i = 0; i < input.Length; i++)
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
