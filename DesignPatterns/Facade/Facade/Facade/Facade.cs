using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade
    {
        Class1 c1 = new Class1();
        Class2 c2 = new Class2();
        Class3 c3 = new Class3();

        public void DoFinalAcion() {
            c1.DoClass1Action();
            c2.DoClass2Action();
            c3.DoClass3Action();
        }
    }
}
