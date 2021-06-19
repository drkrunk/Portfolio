using System;

namespace Builder
{
    class Program
    {

        //The builder separates the constrution of an complex object.
        static void Main(string[] args)
        {
            //Create two diffrent builders. 
            ConcreteBuilder concreteBuilder = new ConcreteBuilder();
            AnotherConcreteBuilder anotherConcreteBuilder = new AnotherConcreteBuilder();

            //Create the director and set inital builder and build.
            Director director = new Director(concreteBuilder);
            director.MakeObject();

            //Create the director and set inital builder and build.
            Director director2 = new Director(anotherConcreteBuilder);
            director2.MakeObject();

            //Get objects from builder.
            Class1 createdObject1 = director.GetObject();
            Class1 createdObject2 = director2.GetObject();

            //Output resulting objects.
            Console.WriteLine(createdObject1.Class1String);
            Console.WriteLine(createdObject2.Class1String);

        }
    }
}
