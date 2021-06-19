using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Factory
    {
        public AbstractClass CreateConcreteClass(string s) {
            if (s == "1") { return new ConcreteClass(); }
            if (s == "2") { return new AnotherConcreteClass(); }
            return null;
        }
    }
}
