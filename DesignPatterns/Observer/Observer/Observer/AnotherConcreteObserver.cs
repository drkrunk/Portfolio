using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class AnotherConcreteObserver : IObserver
    {

        public void Update(string s)
        {
            Console.WriteLine("AnotherConcreteObserver got the update: " + s);
        }
    }
}
