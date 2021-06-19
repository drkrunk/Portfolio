using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IVisitor
    {
        public string Vist(ConcreteElementA element);

        public string Vist(ConcreteElementB element);
    }
}
