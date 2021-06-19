using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{

    //Concrete processor
    class DoLengthProcessor : IProcessor
    {
        //Next link
        IProcessor next;

        //Checks whether to handel the request or pass it to the next chain.
        public void ProcessRequest(Request sender)
        {
            if (sender.TheAction == "length") 
                Console.WriteLine("Do Length Processor: " + sender.TheData.Length);
            else
                next.ProcessRequest(sender);
        }

        //Sets the next link in the chain.
        public void SetNext(IProcessor next)
        {
            this.next = next;
        }
    }
}
