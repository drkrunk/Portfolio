using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    abstract class AbstractClass
    {

        public void TemplateMethod() {
            Hook1();
            Hook2();
            Hook3();
        }


        public abstract void Hook1();
        public abstract void Hook2();
        public abstract void Hook3();
    }
}
