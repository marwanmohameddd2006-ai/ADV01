using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q015
{
    internal interface IShelter<out T> where T : Animal
    {

        T GetAnimal();


    }
       
}
