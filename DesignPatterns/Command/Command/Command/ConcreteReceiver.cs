using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ConcreteReceiver: IReceiver
    {
        //All possible commands
        public void Action1() {
            Console.WriteLine("Receiver did Action1!");
        }

        public void Action2()
        {
            Console.WriteLine("Receiver did Action2!");
        }

        public void Action3()
        {
            Console.WriteLine("Receiver did Action3!");
        }
    }
}
