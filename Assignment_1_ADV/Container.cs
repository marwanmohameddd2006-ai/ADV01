using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV
{
    internal class Container<T>
    {
        private T? Number;
        public T GetNum()
        {
            return Number!;
        }

        public void SetNum(T? value)
        {
            Number = value;
        }
    }
}
