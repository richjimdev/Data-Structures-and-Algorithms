using Hashtables.Classes;
using System;

namespace RepeatedWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

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
