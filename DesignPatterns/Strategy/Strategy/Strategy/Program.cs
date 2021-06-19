using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass class1 = new ConcreteClass();
            AnotherConcreteClass class2 = new AnotherConcreteClass();

            class1.CallFunctionality();
            class2.CallFunctionality();
        }
    }
}
