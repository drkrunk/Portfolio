using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IState
    {
        public void DefinedState();
        public void AnotherState();
        public void ADiffrentState();

        public string GetStateAsString();
    }
}
