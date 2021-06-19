using System;
using System.Collections.Generic;
using System.Text;


//Class1 creates a concrete object of the example interface.
namespace Polymorphism
{
    class Class1 : IExampleInterface
    {

        public void DoWork(){ Console.WriteLine("Class1 did the work with a hammer."); }
    }
}
