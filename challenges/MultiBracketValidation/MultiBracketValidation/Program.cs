using StackAndQueue.Classes;
using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string try1 = "{}(){} - ";
            string try2 = "()[[Extra Characters]] - ";
            string try3 = "{}{Code}[Fellows](()) - ";
            string try4 = "[({}] - ";
            string try5 = "{(}) - ";
            string try6 = "{(({[{ - ";
            string try7 = "";
            string try8 = "Technically this is balanced, as all things should be. - ";

            Console.WriteLine(try1 + MultiBracketVal(try1));
            Console.WriteLine(try2 + MultiBracketVal(try2));
            Console.WriteLine(try3 + MultiBracketVal(try3));
            Console.WriteLine(try4 + MultiBracketVal(try4));
            Console.WriteLine(try5 + MultiBracketVal(try5));
            Console.WriteLine(try6 + MultiBracketVal(try6));
            Console.WriteLine("Empty String - " + MultiBracketVal(try7));
            Console.WriteLine(try8 + MultiBracketVal(try8));
        }

        /// <summary>
        /// This method will take a string and test that any brackets inside will be balanced by closing brackets of the same kind.
        /// </summary>
        /// <param name="input">String to be tested</param>
        /// <returns>Returns a true or false boolean</returns>
        public static bool MultiBracketVal(string input)
        {
            Stack holder = new Stack(null);

            if (input.Length == 0)
                return false;

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
            if (holder.Top == null)
                return true;
            else
                return false;
        }
    }
}
