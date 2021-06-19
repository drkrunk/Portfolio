using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ConcreteState : IState
    {
        private Context context;

        public ConcreteState(Context context) {
            this.context = context;
        }

        public void ADiffrentState()
        {
            Console.WriteLine("Changing state to ADiffrentState.");
            context.SetState(context.ADiffrentConcreteState);
        }

        public void AnotherState()
        {
            Console.WriteLine("Changing state to AnotherState.");
            context.SetState(context.AnotherConcreteState);
        }

        public void DefinedState()
        {
            Console.WriteLine("You are already in the DefinedState!");
        }

        public string GetStateAsString()
        {
            return "DefinedState";
        }
    }
}
