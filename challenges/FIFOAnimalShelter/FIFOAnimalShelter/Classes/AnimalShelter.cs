using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public AnimalShelter(Animal node)
        {
            Front = node;
            Rear = node;
        }

        public Animal Peek()
        {
            return Front;
        }

        public void Enqueue(Animal node)
        {
            Rear.Next = node;
            Rear = node;
        }

        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
