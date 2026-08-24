using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV
{
    internal class EmployeePair<TKey, TValue>
    {
        public EmployeePair(TKey first, TValue second)
        {
            First = first;
            Second = second;
        }


       
        public TKey First { get; set; }
        public TValue Second { get; set; }


        public void Show()
        {
            Console.WriteLine($"{First}---{Second}");
        }
    }
}
