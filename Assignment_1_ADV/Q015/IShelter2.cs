using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q015
{
    internal interface IShelter2<in T> where T : Animal
    {
        void Treat(T animal);
    }
}
