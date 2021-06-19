using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ConcreteRealSubject : ISubject
    {
        
        public string data = "";

        public ConcreteRealSubject() => data = "The protected data!";
       

        public string GetRelevantData()
        {
            return data;
        }

        public void SetData(string d) 
        {
            data = d;
        }

        public void ASuperPoorlyNamedMethodIrrelivantToTheClientButHasToStayPublic() 
        {
            data = data.ToUpper();
        }

        public void DangerousMethod()
        {
            data = "A leet hacker, hacked the data!";
        }
    }
}
