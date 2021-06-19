using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteVisitor vistor = new ConcreteVisitor();
            ConcreteElementA elementA = new ConcreteElementA("Data in element A.");
            ConcreteElementB elementB = new ConcreteElementB("Data in element B.");


            Console.WriteLine(vistor.Vist(elementA));
            Console.WriteLine();
            Console.WriteLine(vistor.Vist(elementB));
          

        }
    }
}
