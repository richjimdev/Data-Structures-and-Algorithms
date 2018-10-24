using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public int Count { get; set; } = 0;

        public AnimalShelter(Animal node)
        {
            Front = node;
            Rear = node;
            Count++;
        }

        public Animal Peek()
        {
            return Front;
        }

        public void Enqueue(Animal node)
        {
            Rear.Next = node;
            Rear = node;
            Count++;
        }

        public Animal Dequeue(string input)
        {
            if (input != "dog" && input != "cat")
                return Dequeue();
            Animal temp = Front;
            if (input == "dog")
            {
                if (Front is Dog)
                    return Dequeue();

                while (!(Front is Dog))
                {
                    Enqueue(Dequeue());
                    if (Front == temp)
                        return null;
                }
            }
            if (input == "cat")
            {
                if (Front is Cat)
                    return Dequeue();

                while (!(Front is Cat))
                {
                    Enqueue(Dequeue());
                    if (Front == temp)
                        return null;
                }
            }

            Animal result = Dequeue();
            while (Front != temp)
            {
                Enqueue(Dequeue());
            }

            return result;
        }

        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            Count--;
            return temp;
        }
    }
}
