using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q015
{
    internal class AnimalShelter : IShelter<Animal>,IShelter2<Animal>
    {
        public Animal GetAnimal()
        {
            return new Animal("A01");
        }

        public void Treat(Animal animal)
        {
            Console.WriteLine("Treating Animal");
        }
    }
}
