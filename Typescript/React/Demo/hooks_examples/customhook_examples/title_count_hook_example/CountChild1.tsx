import React from 'react';
import { useCustomHook } from './CustomHookDemo';

export interface ICountChild1Props {
}

const CountChild1 = (props: ICountChild1Props) => {

    const [count, setCount] = React.useState(0);

    useCustomHook(count);

    return (
        <div>
            <button onClick={() => {setCount(count+1)}}>Count - {count}</button>
        </div>
    );
};
export default CountChild1;