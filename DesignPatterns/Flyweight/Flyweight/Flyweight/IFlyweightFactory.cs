using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    interface IFlyweightFactory
    {
        public Flyweight GetFlyweight(string s);
    }
}
