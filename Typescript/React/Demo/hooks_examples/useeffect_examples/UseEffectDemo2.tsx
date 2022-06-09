import React, { useEffect, useState } from 'react';

// //CONDITIONALLY RUN USE-EFFECTS()


// // The way it would be written using a class(no hooks)
// interface IUseEffectDemo1State {
//     count: number;
//     name: string;
// }

// interface IUseEffectDemo1Props {
// }


// class UseEffectDemo2 extends React.Component<IUseEffectDemo1Props, IUseEffectDemo1State> {

//     constructor(props: IUseEffectDemo1Props) {
//         super(props);

//         this.state = {
//             count: 0,
//             name: ''
//         };

//     }

//     //On first render set title
//     componentDidMount() {
//         document.title = `Clicked ${this.state.count} times`;
//     }

//     //On every update 
//     componentDidUpdate(prevProps: IUseEffectDemo1Props, prevState: IUseEffectDemo1State) {

//         //Only update title when count changes
//         if (prevState.count !== this.state.count) {
//             console.log('Updated title');
//             document.title = `Clicked ${this.state.count} times`;
//         }
//     }


//     public render() {
//         return (
//             <div>
//                 <input type="text" value={this.state.name} onChange={e => { this.setState({ name: e.target.value }); }}></input>
//                 <button onClick={() => this.setState({ count: this.state.count + 1 })}> Click {this.state.count} times </button>
//             </div>
//         );
//     }
// }


//Written as a functional component (with hooks)
const UseEffectDemo2 = () => {

    const [count, setCount] = useState(0);
    const [name, setName] =useState('');

    //eseEffect(function ,dependencies) takes in a function to be called every time one its dependency changes. In this case it's the count.
    useEffect(() => {
        console.log("Updated title");
        document.title = `Clicked ${count} times`;
    },[count]);

    return (
        <div>
            <input type="text" value={name} onChange={(e)=> setName(e.target.value)}></input>
            <button onClick={() => setCount(count + 1)}> Click {count} times </button>
        </div>
    );
};

export default UseEffectDemo2;
