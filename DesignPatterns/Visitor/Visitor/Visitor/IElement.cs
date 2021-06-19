using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IElement
    {
        public string Accept(IVisitor visitor);
    }
}
