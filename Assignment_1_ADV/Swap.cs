using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV
{
    internal class Swap
    {
       
        public static void SwapMethod<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
