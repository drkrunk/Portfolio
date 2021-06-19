using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ConcreteClass : AbstractClass
    {
        public override void Hook1()
        {
            Console.WriteLine("Did hook 1 like a boss!");
        }

        public override void Hook2()
        {
            Console.WriteLine("Did hook 2 while no one was watching!");
        }

        public override void Hook3()
        {
            Console.WriteLine("Did hook 3 like it ment it!");
        }
    }
}
