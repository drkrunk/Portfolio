using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ADiffrentConcreteClass : AbstractClass
    {
        public override void Hook1()
        {
            Console.WriteLine("Did hook 1 reluctantly!");
        }

        public override void Hook2()
        {
            Console.WriteLine("Did hook 2 while wacthing TV!");
        }

        public override void Hook3()
        {
            Console.WriteLine("Didn't do hook 3, just kidding it did!");
        }
    }
}
