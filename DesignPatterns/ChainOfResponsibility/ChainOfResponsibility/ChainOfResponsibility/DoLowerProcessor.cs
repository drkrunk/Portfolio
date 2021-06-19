using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{

    //Concrete processor
    class DoLowerProcessor : IProcessor
    {
        //Next link
        IProcessor next;

        //Checks whether to handel the request or pass it to the next chain.
        public void ProcessRequest(Request sender)
        {
            if (sender.TheAction == "lower") 
                Console.WriteLine("Do Lower Processor: " + sender.TheData.ToLower());
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
