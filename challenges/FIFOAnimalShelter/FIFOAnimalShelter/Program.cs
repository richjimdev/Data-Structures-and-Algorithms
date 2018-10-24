using FIFOAnimalShelter.Classes;
using System;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("dog 1!");
            Dog dog2 = new Dog("dog 2!");
            Dog dog3 = new Dog("dog 3!");
            Cat cat1 = new Cat("cat 1!");
            Cat cat2 = new Cat("cat 2!");

            AnimalShelter shelter = new AnimalShelter(dog1);
            shelter.Enqueue(cat1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(dog3);
            shelter.Enqueue(cat2);

            Console.WriteLine($"First animal in queue is: {shelter.Peek().Value}");
            Console.WriteLine($"Grabbing first cat in queue: {shelter.Dequeue("cat").Value}");
            Console.WriteLine($"Checking that order is back to normal, first animal in queue now is still: {shelter.Peek().Value}");
            Console.WriteLine($"Grabbing first dog in queue: {shelter.Dequeue("dog").Value}");
            Console.WriteLine($"Now first animal in queue is: {shelter.Peek().Value}");
            Console.WriteLine($"Typing anything other than 'dog' or 'cat' will give us first animal: {shelter.Dequeue("horse").Value}");
        }
    }
}
