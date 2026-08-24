using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q015
{
    internal class CatShelter : IShelter<Cat>
    {
        public Cat GetAnimal()
        {
            return new Cat("C01");
        }

        public void Treat(Cat animal)
        {
            Console.WriteLine("Treating Cat");
        }
    }
}
