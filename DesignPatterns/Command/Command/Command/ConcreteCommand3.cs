using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{

    class ConcreteCommand3: ICommand
    {
        private IReceiver receiverObject;

        public ConcreteCommand3(ConcreteReceiver receiver){
            this.receiverObject = receiver;
        }

        //Encapsulates actions from the receiver.
        public void Execute()
        {
            receiverObject.Action3(); ;
        }
    }
}
