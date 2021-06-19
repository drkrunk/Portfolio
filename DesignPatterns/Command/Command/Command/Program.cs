using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteReceiver receiver = new ConcreteReceiver();

            //Create commands for the receiver
            ConcreteCommand1 c1 = new ConcreteCommand1(receiver);
            ConcreteCommand2 c2 = new ConcreteCommand2(receiver);
            ConcreteCommand3 c3 = new ConcreteCommand3(receiver);

            //Calls commands on the receiver
            Invoker invoker = new Invoker(c1);
            invoker.DoCommand(); // Calls action1 on the receiver

            invoker.Command = c2;
            invoker.DoCommand();// Calls action2 on the receiver

            invoker.Command = c3;
            invoker.DoCommand();// Calls action3 on the receiver

        }
    }
}
