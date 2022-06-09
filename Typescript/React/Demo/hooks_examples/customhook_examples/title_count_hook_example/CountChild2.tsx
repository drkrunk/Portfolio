import React from 'react';
import { useCustomHook } from './CustomHookDemo';

export interface ICountChild2Props {
}

const CountChild2 = (props: ICountChild2Props) => {

    const [count, setCount] = React.useState(0);

    useCustomHook(count);

    return (
        <div>
            <button onClick={() => {setCount(count+1)}}>Count - {count}</button>
        </div>
    );
};
export default CountChild2;