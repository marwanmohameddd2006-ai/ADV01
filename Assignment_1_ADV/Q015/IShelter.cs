using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q015
{
    internal interface IShelter<out T> where T : Animal
    {
        //out position => T will act correctly
         T GetAnimal();

       

        //void SetAnimal(T animal);
        //void Treat(T animal);
    }
}
