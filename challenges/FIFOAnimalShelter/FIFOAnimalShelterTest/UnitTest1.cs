using FIFOAnimalShelter.Classes;
using System;
using Xunit;

namespace FIFOAnimalShelterTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing that animal shelter can accept Dog class
        /// </summary>
        [Fact]
        public void AnimalShelterCanAcceptDogs()
        {
            Dog dog1 = new Dog("dog1");
            AnimalShelter shelter = new AnimalShelter(dog1);

            Assert.Equal("dog1", shelter.Front.Value);
        }

        /// <summary>
        /// Testing that animal shelter can accept Cat class
        /// </summary>
        [Fact]
        public void AnimalShelterCanAcceptCats()
        {
            Cat cat1 = new Cat("cat1");
            AnimalShelter shelter = new AnimalShelter(cat1);

            Assert.Equal("cat1", shelter.Front.Value);
        }

        [Fact]
        public void EnqueueAddsToTheEndOfQueue()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            AnimalShelter shelter = new AnimalShelter(cat1);
            shelter.Enqueue(dog1);

            Assert.Equal("dog1", shelter.Rear.Value);
        }

        [Fact]
        public void DequeueReturnsAnimalAtFrontOfQueue()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            AnimalShelter shelter = new AnimalShelter(cat1);
            shelter.Enqueue(dog1);

            Assert.Equal("cat1", shelter.Dequeue().Value);
        }

        [Fact]
        public void DequeueWithDogInputReturnsFirstDogInQueue()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(cat1);
            shelter.Enqueue(dog1);
            shelter.Enqueue(dog2);

            Assert.Equal("dog1", shelter.Dequeue("dog").Value);
        }

        [Fact]
        public void DequeueWithCatInputReturnsFirstCatInQueue()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(dog1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(cat1);

            Assert.Equal("cat1", shelter.Dequeue("cat").Value);
        }

        [Fact]
        public void DequeueWithOtherInputReturnsFirstAnimalInQueue()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(dog1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(cat1);

            Assert.Equal("dog1", shelter.Dequeue("horse").Value);
        }

        [Fact]
        public void DequeueWithInputKeepsOriginalOrderOfAnimals()
        {
            Cat cat1 = new Cat("cat1");
            Dog dog1 = new Dog("dog1");
            Dog dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(dog1);
            shelter.Enqueue(cat1);
            shelter.Enqueue(dog2);
            shelter.Dequeue("cat");

            Assert.Equal("dog1", shelter.Front.Value);
        }
    }
}
