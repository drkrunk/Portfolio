using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //A Concrete builder builds complex objects with certain parameters diffrent from other builders.
    class AnotherConcreteBuilder : IBuilder
    {
        private Class1 ObjToBeBuilt;

        public AnotherConcreteBuilder()
        {
            this.ObjToBeBuilt = new Class1() ;
        }

        public void BuildPartA()
        {
            ObjToBeBuilt.Class1String += "Another Concrete Builder: Added part 1!\n";
        }

        public void BuildPartB()
        {
            ObjToBeBuilt.Class1String += "Another Concrete Builder: Added part 2!\n";
        }

        public void BuildPartC()
        {
            ObjToBeBuilt.Class1String += "Another Concrete Builder: Added part 3!\n";
        }

        public Class1 GetObject()
        {
            return ObjToBeBuilt;
        }
    }
}
