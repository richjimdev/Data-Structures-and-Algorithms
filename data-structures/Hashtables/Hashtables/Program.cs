using Hashtables.Classes;
using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hashtable hs = new Hashtable();

            Console.WriteLine(hs.GetHashKey("Dog"));
            Console.WriteLine(hs.GetHashKey("Dogg"));
        }
    }
}
