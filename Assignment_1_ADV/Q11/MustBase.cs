using Assignment_1_ADV.Q10;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q11
{
    internal class MustBase<T> where T : Base , ITest,new()
    {
       public void DisPlay(T t)
        {
           t.Great();
        }
        public T Creat()
        {
            return new T();
        }
    }
}
