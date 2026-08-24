using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q10
{
    internal class Printer<T> where T : ITest
    {
        public void print2(T item)
        {
            item.print();
        }
    }
}
