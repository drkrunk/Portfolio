using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    //Invokes commands on the reciever
    class Invoker
    {
        
        public ICommand Command { get; set; }
        public Invoker(ICommand command)
        {
            Command = command;
        }

        //Call commands
        public void DoCommand() 
        {
            Command.Execute();
        }
    }
}
