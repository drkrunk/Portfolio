using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObserver
    {
        public void Update(string s);
    }
}
