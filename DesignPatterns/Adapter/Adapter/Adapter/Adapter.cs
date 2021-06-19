using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{

    class Adapter : ITarget
    {
        Adaptee adaptee;
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee; 
        }

        public void Action1()
        {
            adaptee.Action4();
        }

        public void Action2()
        {
            adaptee.Action5();
        }

        public void Action3()
        {
            adaptee.Action6();
        }

    }
}
