using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ADiffrentConcreteState : IState
    {
        private Context context;

        public ADiffrentConcreteState(Context context) {
            this.context = context;
        }

        public void ADiffrentState()
        {
            Console.WriteLine("You are already in the ADiffrentState!");
        }

        public void AnotherState()
        {
            Console.WriteLine("Changing state to AnotherState.");
            context.SetState(context.AnotherConcreteState);
        }

        public void DefinedState()
        {
            Console.WriteLine("Changing state to DefinedtState.");
            context.SetState(context.ConcreteState);
        }

        public string GetStateAsString()
        {
            return "ADiffrentConcreteState";
        }
    }
}
