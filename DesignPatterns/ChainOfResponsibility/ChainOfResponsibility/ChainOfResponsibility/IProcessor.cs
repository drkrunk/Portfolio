using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    //This the processor interface.
    interface IProcessor
    {
        //Set next link in the chain.
        public void SetNext(IProcessor next);

        //Process current link.
        public void ProcessRequest(Request sender);
    }
}
