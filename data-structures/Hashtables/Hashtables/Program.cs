using Hashtables.Classes;
using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating
            Hashtable hs = new Hashtable();

            //Adding
            hs.Add("Greeting", "Hi");
            hs.Add("Name", "Richard");
            hs.Add("Animal", "Dog");

            //Forcing a collision
            hs.Add("Video Game", "Mario 64");
            hs.Add("Aged Movie", "Jaws");

            //proving all added keys exist
            Console.WriteLine(hs.Contains("Greeting"));
            Console.WriteLine(hs.Contains("Name"));
            Console.WriteLine(hs.Contains("Animal"));

            Console.WriteLine(hs.Contains("Video Game"));
            Console.WriteLine(hs.Contains("Aged Movie"));

            Console.WriteLine(hs.Contains("Something Else"));
        }
    }
}
