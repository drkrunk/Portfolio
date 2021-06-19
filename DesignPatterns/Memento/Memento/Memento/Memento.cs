using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Memento
    {
        public string State { get; }
        public Memento(string stateToSave)
        {
            State = stateToSave;
        }
    }
}
