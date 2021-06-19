using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class YetAnotherDecorator : AbstractDecorator
    {

        public YetAnotherDecorator(IComponent objToBeDecorated) : base(objToBeDecorated){}

        public override string Print()
        {

            return base.Print() + " | YetAnotherDecorator";
        }
    }
}
