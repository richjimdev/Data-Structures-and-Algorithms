using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    /// <summary>
    /// Inherited from animal
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Builds a dog with a value
        /// </summary>
        /// <param name="value">Value to be put in dog</param>
        public Dog(object value)
        {
            Value = value;
        }
    }
}
