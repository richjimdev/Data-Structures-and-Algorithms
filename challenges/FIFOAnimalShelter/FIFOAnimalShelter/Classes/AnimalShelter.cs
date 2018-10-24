using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    /// <summary>
    /// A class build like a queue to take in animals
    /// </summary>
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        /// <summary>
        /// A constructor that takes in an animal
        /// </summary>
        /// <param name="animal">An animal class (descendant)</param>
        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        /// <summary>
        /// Returns the animal at front of queue
        /// </summary>
        /// <returns>An animal </returns>
        public Animal Peek()
        {
            return Front;
        }

        /// <summary>
        /// Adds an animal to the rear of the queue
        /// </summary>
        /// <param name="animal">The animal to be added</param>
        public void Enqueue(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
        }

        /// <summary>
        /// Overload. Removes an animal, with specific input, from the front of queue
        /// </summary>
        /// <param name="input">Animal to be removed, as a string</param>
        /// <returns>The removed animal</returns>
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

        /// <summary>
        /// Removes the first animal in the queue
        /// </summary>
        /// <returns>The removed animal</returns>
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
