using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{

    class Adaptee
    {

        public void Action4()
        {
            Console.WriteLine("Adaptee Action4: It did a simular thing.");
        }

        public void Action5()
        {
            Console.WriteLine("Adaptee Action5: It did a simular diffrent thing.");
        }

        public void Action6()
        {
            Console.WriteLine("Adaptee Action6: It did a totally expected thing.");
        }

    }
}
