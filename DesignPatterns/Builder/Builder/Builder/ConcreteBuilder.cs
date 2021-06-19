using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //A Concrete builder builds complex objects with certain parameters diffrent from other builders.
    class ConcreteBuilder : IBuilder
    {
        private Class1 ObjToBeBuilt;

        public ConcreteBuilder()
        {
            this.ObjToBeBuilt = new Class1();
        }

        public void BuildPartA()
        {
            ObjToBeBuilt.Class1String += "Concrete Builder: Added part a!\n";
        }

        public void BuildPartB()
        {
            ObjToBeBuilt.Class1String += "Concrete Builder: Added part b!\n";
        }

        public void BuildPartC()
        {
            ObjToBeBuilt.Class1String += "Concrete Builder: Added part c!\n";
        }

        public Class1 GetObject()
        {
            return ObjToBeBuilt;
        }
    }
}
