import React, { ReducerState, useReducer } from 'react';

export interface IUseReducerDemo1Props {
}

const initialState = 0;

//Very basic reducer
const reducer = (state: number, action: string): number => {
    switch (action) {
        case 'increment':
            return state + 1;
        case 'decrement':
            return state - 1;
        case 'reset':
            return initialState;
        default:
            return state;
    }
};

const UseReducerDemo1 = (props: IUseReducerDemo1Props) => {

    const [count, dispatch] = useReducer(reducer, initialState);

    return (
        <div>
            Count = {count}
            <button onClick={()=>dispatch('increment')}>Increment</button>
            <button onClick={()=>dispatch('decrement')}>Decrement</button>
            <button onClick={()=>dispatch('reset')}>Reset</button>
        </div>
    );
};

export default UseReducerDemo1;






