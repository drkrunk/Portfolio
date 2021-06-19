using System;

namespace Decorator
{
    class Program
    {
        //the decorator pattern is a design pattern that allows behavior to be added to an 
        //individual object, dynamically, without affecting the behavior of other objects from the same class.
        static void Main(string[] args)
        {
            //DecoratedObj contains a ref to new decoratedObj within.
            IComponent decoratedObj = new YetAnotherDecorator( new ADiffrentDecorator( new ConcreteDecorator(new ConcreteComponent())));

            IComponent decoratedObj2 = new YetAnotherDecorator(new ConcreteComponent());

            //Bubbles down the referances adding functionality to the object at each step.
            Console.WriteLine(decoratedObj.Print());
            Console.WriteLine(decoratedObj2.Print());

        }
    }
}
