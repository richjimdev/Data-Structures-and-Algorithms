using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    /// <summary>
    /// Base class for our animals
    /// </summary>
    public abstract class Animal
    {
        public object Value { get; set; }
        public Animal Next { get; set; }
    }
}
