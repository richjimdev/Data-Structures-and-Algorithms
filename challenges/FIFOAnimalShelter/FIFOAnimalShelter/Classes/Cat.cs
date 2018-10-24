using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    /// <summary>
    /// Inherited from animal
    /// </summary>
    public class Cat : Animal
    {
        /// <summary>
        /// Builds a cat with a value
        /// </summary>
        /// <param name="value">Value to be put in cat</param>
        public Cat(object value)
        {
            Value = value;
        }
    }
}
