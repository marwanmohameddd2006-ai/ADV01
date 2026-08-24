using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q09
{
    internal class Person2
    {
        public Person2()
        {

        }
        public Person2(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
