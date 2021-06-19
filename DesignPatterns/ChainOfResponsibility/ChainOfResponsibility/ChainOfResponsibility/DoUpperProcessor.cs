using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    //Concrete processor
    class DoUpperProcessor : IProcessor
    {

        //Next link
        IProcessor next;

        //Checks whether to handle the request or pass it to the next chain.
        public void ProcessRequest(Request sender)
        {
            if (sender.TheAction == "upper") 
                Console.WriteLine("Do Upper Processor:" + sender.TheData.ToUpper());
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
