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
