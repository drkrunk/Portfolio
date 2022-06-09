import React, { useState } from 'react';


//The hook implementation of the a simple counter 
export default function CountHook() {
    const initialCount = 0;
    const [count, setCount] = useState(initialCount); //<= example of the useState hook.

    return (
        <React.Fragment>
            Count:{count}
            <button onClick={() => setCount(initialCount)}> Reset</button>
            <button onClick={() => setCount(prevCount => prevCount +1)}> Increment </button>
            <button onClick={() => setCount(prevCount => prevCount -1)}> Decrement </button>
        </React.Fragment>
    );
}
