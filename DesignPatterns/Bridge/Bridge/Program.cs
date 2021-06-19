using System;

namespace Bridge
{
    class Program
    {

        //The bridge pattern decouples abstraction from implementation.
        static void Main(string[] args)
        {
            Console.WriteLine("This is an example of the bridge pattern.");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("OBJECT CREATION\n");

            //Create two differenct example concrete bridges.
            Console.WriteLine("Creating 2 bridge objects with diffrent implementations...");
            ConcreteBridge1 concreteBridge1 = new ConcreteBridge1();
            ConcreteBridge2 concreteBridge2 = new ConcreteBridge2();

            //Set the functionality from the concreteBridge1 class.
            Console.WriteLine("Creating an abstract bridge object with bridge 1 functionality...");
            ConcreteAbstractBridge concreteAbstractBridge = new ConcreteAbstractBridge(concreteBridge1);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("CALL BRIDGE1 FUNCTIONALITY\n");

            //It recieves it functionality from the concreteBridge1 class.
            Console.WriteLine("Call funtions from the abstract bridge object...");
            concreteAbstractBridge.CallAction1();
            concreteAbstractBridge.CallAction2();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("CHANGE FUNCTIONALITY\n");

            //It's changed at runtime to recieve it functionality form the concreteBridge2 class.
            Console.WriteLine("Change the abstract bridge functionality to bridge 2 ...\n");
            concreteAbstractBridge.Bridge = concreteBridge2;
            Console.WriteLine("-----------------------------------------");

            //It recieves it functionality form the concreteBridge2 class
            Console.WriteLine("CALL BRIDGE2 FUNCTIONALITY\n");
            Console.WriteLine("Call funtions from the abstract bridge object...\n");
            concreteAbstractBridge.CallAction1();
            concreteAbstractBridge.CallAction2();

            Console.WriteLine("-----------------------------------------\n");
        }
    }
}
