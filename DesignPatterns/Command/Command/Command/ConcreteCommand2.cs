using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ConcreteCommand2: ICommand
    {
        private IReceiver receiverObject;

        public ConcreteCommand2(ConcreteReceiver receiver)
        {
            this.receiverObject = receiver;
        }

        //Encapsulates actions from the receiver.
        public void Execute()
        {
            receiverObject.Action2(); ;
        }
    }
}
