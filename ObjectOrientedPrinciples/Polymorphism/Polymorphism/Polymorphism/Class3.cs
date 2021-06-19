using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    //Class2 creates a concrete object of the example interface.
    class Class3 : IExampleInterface
    {
        //Implementation of the functionality of the interface.

        public void DoWork() { Console.WriteLine("Class3 did the work with a wrench."); }
    }
}
