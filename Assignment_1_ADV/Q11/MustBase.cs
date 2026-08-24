using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q11
{
    internal class MustBase<T> where T : Base
    {
       public void DisPlay(T t)
        {
           t.Great();
        }
    }
}
