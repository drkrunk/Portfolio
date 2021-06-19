using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Proxy : ISubject
    {
        public string GetRelevantData()
        {
            ConcreteRealSubject realSubject = new ConcreteRealSubject();
            
            return realSubject.data;
        }
    }
}
