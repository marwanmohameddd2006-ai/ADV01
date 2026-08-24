using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q09
{
    internal class Test3<T> where T : new()
    {
        public T Creat() 
        {
            return  new T();
        }
    }
}
