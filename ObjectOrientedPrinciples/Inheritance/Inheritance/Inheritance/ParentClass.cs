using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    /*
    Example of a parent class. (Ignoring ParentClass is actually a child of AbstractClass)
    */
    class ParentClass : AbstractClass
    {
        public String ParentProperty { get; set; }

        public ParentClass() {
            ParentProperty = "ParentProperty";
        }

        public void ParentMethod()
        {
            Console.WriteLine("ParentMethod() called!");
        }

        public virtual void OverrideParentMethod()
        {
            Console.WriteLine("OverrideParentMethod() called from parent!");
        }

        public void PrintParentProperty() {
            Console.WriteLine(this.ParentProperty);
        }

        public override void AbstractClassMethod(){
            Console.WriteLine("Implementation from parent of AbstractClassMethod() Called!");
        }
    }
}
