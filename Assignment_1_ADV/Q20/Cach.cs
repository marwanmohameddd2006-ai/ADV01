using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q20
{
    internal class Cach<TKey,  TValue>
    {
        private List<TKey> item1 = [];
        private List<TValue> item2 = [];

        public void Add(TKey key , TValue value)
        {
            item1.Add(key);
            item2.Add(value);
        }

       
    }
}
