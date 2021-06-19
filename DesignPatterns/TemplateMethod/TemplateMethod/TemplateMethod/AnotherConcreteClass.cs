using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class AnotherConcreteClass : AbstractClass
    {
        public override void Hook1(){}

        public override void Hook2()
        {
            Console.WriteLine("Did hook 2 and did it willingly!");
        }
        public override void Hook3(){}
    }
}
