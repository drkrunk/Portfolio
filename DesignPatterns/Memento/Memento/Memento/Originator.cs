using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Originator
    {
        private string state;

        public void SetState(string s) { state = s; }

        public Memento Create() {
            Console.WriteLine("Originator: Created a memento: " + state);
            return new Memento(state);
        }
        public void Restore(Memento savedState) {
            this.state = savedState.State;
            Console.WriteLine("Originator: Restored memento: " + state);
        }
    }
}
