using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class ConcreteElementA : IElement
    {

        public string ElementAProp { get; set; }

        public ConcreteElementA(string s)
        {
            ElementAProp = s;
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.Vist(this);
        }
    }
}
