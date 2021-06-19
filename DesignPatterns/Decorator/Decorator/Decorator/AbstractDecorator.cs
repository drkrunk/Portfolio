using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class AbstractDecorator : IComponent
    {
        //The next component in the chain.
        private IComponent objToBeDecorated;

        public AbstractDecorator(IComponent objToBeDecorated)
        {
            this.objToBeDecorated = objToBeDecorated;
        }

        public virtual string Print(){ return objToBeDecorated.Print(); }
    }
}
