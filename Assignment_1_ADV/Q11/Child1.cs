using Assignment_1_ADV.Q10;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_ADV.Q11
{
    internal class Child1 : Base , ITest 
    {
        
        public Child1() :base(default!)
        {

        }
        public Child1(string name) : base(name)
        {
        }
       
        public override void Great()
        {
            Console.WriteLine("Hello I Child_1");
        }

        public void print()
        {
            Console.WriteLine("Hello I Child_1");
        }
        
    }
}
