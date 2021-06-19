using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    //Uses composition to modify it's functionality; decoupling it from in its implementation. 
    class ConcreteAbstractBridge : IAbstractBridge
    {

        public IBridge Bridge { get; set; }

        public ConcreteAbstractBridge(IBridge bridge)
        {
            this.Bridge = bridge;
        }

        public void CallAction1()
        {
            this.Bridge.Action1(); //Implements the functionallity
        }

        public void CallAction2()
        {
            this.Bridge.Action2(); //Implements the functionallity
        }
    }
}
