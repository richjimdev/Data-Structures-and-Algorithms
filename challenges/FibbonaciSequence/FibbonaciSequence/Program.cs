using System;

namespace FibbonaciSequence
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
        public int FindFib(int index)
        {
            int num1 = 0;
            int num2 = 1;
            int current = 1;

            for (int i = 0; i < index-1; i++)
            {
                current = num1 + num2;
                num1 = num2;
                num2 = current;
            }

            return current;
        }
    }
}
