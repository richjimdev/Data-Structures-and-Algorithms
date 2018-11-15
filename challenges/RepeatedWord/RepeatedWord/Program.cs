using Hashtables.Classes;
using System;

namespace RepeatedWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string test1 = "The quick brown fox jumped over the lazy brown dog.";

            Console.WriteLine(Repeated(test1));
        }

        /// <summary>
        /// Take in a string, and return the first repeated word in the string
        /// </summary>
        /// <param name="input">String to test</param>
        /// <returns>Repeated word</returns>
        public static string Repeated(string input)
        {
            string[] inputArr = input.ToLower().Split(" ");

            Hashtable ht = new Hashtable();

            foreach (string word in inputArr)
            {
                if (ht.Contains(word))
                    return word;
                else
                    ht.Add(word, word);
            }

            return "NO DUPLICATES";
        }
    }
}
