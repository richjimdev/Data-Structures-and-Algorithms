using System;
using System.Collections.Generic;

namespace EeneyMeeney
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string> { "Richard", "Danul", "Allisa", "Kendra", "Suzzie" };

            MineyMo(names, 3);
        }

        public static string MineyMo(List<string> names, int num)
        {
            int count = names.Count;

            Queue<string> nameQueue = new Queue<string>(names);

            while (count > 1)
            {
                for (int i = 0; i < num - 1; i++)
                {
                    nameQueue.Enqueue(nameQueue.Dequeue());
                }
                Console.WriteLine($"Eeney Meeney Miney Mo.... {nameQueue.Dequeue()} is out!");
                count--;
            }
            string result = nameQueue.Dequeue();
            Console.WriteLine($"{result} wins!");

            return result;
        }
    }
}
