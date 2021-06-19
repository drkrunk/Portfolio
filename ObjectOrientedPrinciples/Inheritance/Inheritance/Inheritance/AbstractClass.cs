using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    /*
    The keyword abstract pervents the class from being instantiated.
    */
    abstract class AbstractClass
    {
        //Abstract methods forces the any class extending AbstractClass to implement it's functionality.
        public abstract void AbstractClassMethod();
    }
}
