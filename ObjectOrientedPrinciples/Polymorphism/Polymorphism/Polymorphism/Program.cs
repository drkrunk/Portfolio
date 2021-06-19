using System;

//The program illustates the use of Polymorphism.

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creates objects of that the classes that implements the example interface.  
            IExampleInterface object1 = new Class1();
            IExampleInterface object2 = new Class2();
            IExampleInterface object3 = new Class3();

            //Calls the methods of implemented method of the interfaces for each object.
            Console.WriteLine("Do base functionality of each created object: \n");
            Console.WriteLine("-----------------------------\n");
            object1.DoWork();
            object2.DoWork();
            object3.DoWork();
            Console.WriteLine("-----------------------------\n");

            Console.WriteLine("Change object1 to object3's functionality at runtime!");

            //Dyanmically changes object1 functionality at runtime, by chaning it's object.
            object1 = new Class3();
            object1.DoWork();
        }
    }
}
