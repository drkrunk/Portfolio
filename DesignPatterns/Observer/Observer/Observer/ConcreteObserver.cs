using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConcreteObserver : IObserver
    {
        public void Update(string s)
        {
            Console.WriteLine("ConcreteObserver got the update: " + s);
        }
    }
}
