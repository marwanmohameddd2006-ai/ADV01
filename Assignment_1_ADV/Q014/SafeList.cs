using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q014
{
    internal class SafeList<T>
    {
        private List<T> items = [];



        public void Add(T item)
        {
            items.Add(item);
        }


        public T GetElementAt(int index)   // 7 5 : 0-4
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }

            return default(T)!;
            

        }

    }
}
