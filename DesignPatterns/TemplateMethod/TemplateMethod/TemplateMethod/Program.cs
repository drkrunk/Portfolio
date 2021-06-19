using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass concreteClass = new ConcreteClass();
            AnotherConcreteClass anotherConcreteClass = new AnotherConcreteClass();
            ADiffrentConcreteClass aDiffrentConcreteClass = new ADiffrentConcreteClass();

            concreteClass.TemplateMethod();
            Console.WriteLine();

            anotherConcreteClass.TemplateMethod();
            Console.WriteLine();

            aDiffrentConcreteClass.TemplateMethod();
            Console.WriteLine();
        }
    }
}
