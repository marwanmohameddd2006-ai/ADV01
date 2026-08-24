using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV
{
    internal interface IRepository<T>
    {
        void Create(T item);
        List<T> GetAll();
        T GetById(int id);
        void Delete(int id);
    }
}
