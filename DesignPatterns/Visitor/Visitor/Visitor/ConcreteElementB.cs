using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class ConcreteElementB : IElement
    {

        public string ElementBProp { get; set; }

        public ConcreteElementB(string s)
        {
            ElementBProp = s;
        }

        public string Accept(IVisitor visitor)
        {
            return visitor.Vist(this);
        }
    }
}
