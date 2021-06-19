using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class ConcreteVisitor : IVisitor
    {
        public string Vist(ConcreteElementA element)
        {
            Console.WriteLine("Visiting With ElementA: " + element.ElementAProp);
            return element.ElementAProp + " + The cool new data added by ConcreteVisitor.";
        }

        public string Vist(ConcreteElementB element)
        {
            Console.WriteLine("Visiting With ElementB: " + element.ElementBProp);
            return element.ElementBProp + " + The not so cool new data added by ConcreteVisitor.";
        }
    }
}
