using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    /*
    Example of a child class. 
    */
    class ChildClass : ParentClass
    {
        public String ChildProperty { get; set; }

        public ChildClass() {
            ChildProperty = "ChildProperty";
        }

        public void ChildMethod()
        {
            Console.WriteLine("ChildMethod() called!");
        }

        public override void OverrideParentMethod()
        {
            Console.WriteLine("OverrideParentMethod() called from child!");
        }

        public void PrintChildProperty()
        {
            Console.WriteLine(this.ChildProperty);
        }

    }
}
