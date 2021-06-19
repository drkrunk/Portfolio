using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    //Class2 creates a concrete object of the example interface.
    class Class2 : IExampleInterface
    {

        //Implementation of the functionality of the interface.
        public void DoWork() { Console.WriteLine("Class2 did the work with a screwdriver."); }
    }
}
