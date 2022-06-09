import { MouseEventHandler } from 'react';
import useCounter from './UseCounter';

export default function Counter2() {

    const [count, increment, decrement, reset] = useCounter();

    return (
        <div>
            <div>Count = {count}</div>
            <button onClick={increment as MouseEventHandler<HTMLButtonElement>}>Increment</button>
            <button onClick={decrement as MouseEventHandler<HTMLButtonElement>}>Decrement</button>
            <button onClick={reset as MouseEventHandler<HTMLButtonElement>}>Reset</button>
        </div>
    );
}


