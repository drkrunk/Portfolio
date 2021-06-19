using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //Methods of what a builder needs to build.
    interface IBuilder
    {
        public void BuildPartA();
        public void BuildPartB();
        public void BuildPartC();

        public Class1 GetObject();
    }
}
