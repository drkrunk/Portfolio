using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    abstract class BaseClass
    {
        //Polymorphic
        public ICommonFunctionality ClassFunctionality { get; set; }

        public void CallFunctionality()
        {
            this.ClassFunctionality.DoSomething();
        }
    }
}
