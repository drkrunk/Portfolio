using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    
    class Context
    {
        public IState ConcreteState { get; }
        public IState AnotherConcreteState { get; }
        public IState ADiffrentConcreteState { get; }

        private IState currentState;

        public Context() {
            currentState = new ConcreteState(this);
            AnotherConcreteState = new AnotherConcreteState(this);
            ADiffrentConcreteState = new ADiffrentConcreteState(this);
            ConcreteState = new ConcreteState(this);
        }

        public void SetState(IState newState) {
            currentState = newState;
        }

        public void ChangeToDefinedState() {
            currentState.DefinedState();
        }

        public void ChangeToAnotherState() { 
            currentState.AnotherState();
        }

        public void ChangeToADiffrentState() { 
            currentState.ADiffrentState(); 
        }

        public string GetStateAsString() {
            return currentState.GetStateAsString();
        }

    }
}
