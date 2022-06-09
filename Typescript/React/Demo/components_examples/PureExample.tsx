import React, { PureComponent } from 'react';

//The key differences between a regular component and pure component is 
//pure component implements te shouldComponentUpdate with shallow props and state comparisons
//while a regular component returns true by default

//Shallow comparison (SC)
//-Primitive Types
//--SC returns True if a and b have the same value and same type
//--Ex: 'string1' === 'string1'

//-Complex Types
//--SC returns true if and and b reference the exact same object
//--ex: 
//---var a = [1,2,3];
//---var b = [1,2,3];
//---var c = a;
//---(a===b);  returns false
//---(a===c); returns true

//Pure component will only re-render 
//-if there is a difference (SC) of prevState and currentState or
//-if there is a difference (SC) of prevProps and currentProps
//In the shouldComponentUpdate method


//Best practice note 
//-Ensure that the children components are also pure to a avoid unexpected behavior.
//-Never mutate the state. Always return a new object that reflects the new state.
//-Use regular components unless you need a performance boost in an specific component

//Extends React.PureComponent and thus is a class base component.
class PureExample extends PureComponent {

    public render() {
        return <div>PureComponent </div>;
    }
}
