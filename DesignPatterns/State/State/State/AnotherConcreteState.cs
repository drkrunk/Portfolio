using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class AnotherConcreteState : IState
    {
        private Context context;

        public AnotherConcreteState(Context context) {
            this.context = context;
        }

        public void ADiffrentState()
        {
            Console.WriteLine("Changing state to ADiffrentState.");
            context.SetState(context.ADiffrentConcreteState);
        }

        public void AnotherState()
        {
            
            Console.WriteLine("You are already in the AnotherState!");
        }

        public void DefinedState()
        {
            Console.WriteLine("Changing state to DefinedState.");
            context.SetState(context.ConcreteState);
        }

        public string GetStateAsString()
        {
            return "AnotherState";
        }
    }
}
