import React, {useState} from 'react';

/*The class implementation of a simple counter

export default class CountClass extends React.Component<{}, {count:number}> {
    constructor(props:any) {
        super(props);
        this.state = {count: 0};
    }

    increment = () => {
        this.setState((prevState) => {return{count: prevState.count + 1} });
    };

    public render() {
        return <button onClick={this.increment}>Has been clicked {this.state.count} times</button>  
    }
}
export default CountClass;
*/


//The hook implementation of the a simple counter 
export default function CountHook() {
    //Array destructuring
    const [count, setCount] = useState(0); //<= example of the useState hook.
    return <button onClick={()=>setCount(count +1)}> Count {count} </button>
}
