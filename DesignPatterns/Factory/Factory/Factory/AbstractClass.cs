using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class AbstractClass
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public void Print() { Console.WriteLine("Name: "+Name + ", Value: " + Value); }
    }
}
