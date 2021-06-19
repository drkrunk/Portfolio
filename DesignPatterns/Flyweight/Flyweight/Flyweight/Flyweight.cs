using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Flyweight
    {
        public string FlyWeightProperty { get; set; }

        public Flyweight(string prop) => FlyWeightProperty = prop;

        public void Print() { Console.WriteLine("FlyWeight: " + FlyWeightProperty); }

    }
}
