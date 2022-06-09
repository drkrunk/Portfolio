import React, { useEffect, useState } from 'react';

// // THIS EXAMPLE SHOWS HOW TO USE USE-EFFECT

//The way it would be written using a class (without hooks)
// interface IUseEffectDemo1State {
//     count: number;
// }

// class UseEffectDemo1 extends React.Component<{}, IUseEffectDemo1State> {

//     constructor(props: any) {
//         super(props);

//         this.state = {
//             count: 0
//         };

//     }

//     //On first render set title
//     componentDidMount() {
//         document.title = `Clicked ${this.state.count} times`;
//     }

//     //On every update set title
//     componentDidUpdate() {
//         document.title = `Clicked ${this.state.count} times`;
//     }


//     public render() {
//         return (
//             <div>
//                 <button onClick={() => this.setState({ count: this.state.count + 1 })}> Click {this.state.count} times </button>
//             </div>
//         );
//     }
// }


//This is the functional component implementation (with hooks) 
const UseEffectDemo1 = () => {

    const [count, setCount] = useState(0);

    //eseEffect(function) takes in a function to be called every time a update happens.
    useEffect(() => {
        document.title = `Clicked ${count} times`;
    });

    return (
        <div>
            <button onClick={() => setCount(count + 1)}> Click {count} times </button>
        </div>
    );
};

export default UseEffectDemo1;
