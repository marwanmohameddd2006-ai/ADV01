using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV
{
    internal class FindMax
    {
        public static T FindMaxMethod<T>(T[] items) where T : IComparable<T>
        {
            if (items is not null && items.Length > 0)
            {
                T maxvalue = items[0];
                for (int i = 0; i < items.Length; i++)
                {
                   
                    if (items[i].CompareTo(maxvalue) > 0)
                        maxvalue = items[i];
                }
                return maxvalue;
            }
            return default!;
        }
    }
}
