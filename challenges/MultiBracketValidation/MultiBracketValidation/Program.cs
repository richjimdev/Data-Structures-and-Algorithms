using StackAndQueue.Classes;
using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static bool MultiBracketValidation(string input)
        {
            Stack holder = new Stack(null);

            foreach (char x in input)
            {
                string letter = x.ToString();

                if (letter == "(")
                    holder.Push(new Node(")"));
                if (letter == "{")
                    holder.Push(new Node("}"));
                if (letter == "[")
                    holder.Push(new Node("]"));

                if (letter == ")" ||
                    letter == "}" ||
                    letter == "]")
                {
                    if (holder.Top == null)
                        return false;
                    if (letter != holder.Pop().Value.ToString())
                        return false;
                }
            }

            return true;
        }
    }
}
