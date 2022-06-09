import React ,{useState, useEffect} from 'react';

// // THIS EXAMPLE SHOWS HOW TO RUN USE-EFFECT TO CLEAN UP CODE 

// // Using the class implementation (without hooks)
// export interface IUseEffectDemo4Props {
// }

// export interface IUseEffectDemo4State {
//     x: number;
//     y: number;
// }

// class UseEffectDemo4 extends React.Component<IUseEffectDemo4Props, IUseEffectDemo4State> {
//     constructor(props: IUseEffectDemo3Props) {
//         super(props);

//         this.state = {
//             x: 0,
//             y: 0
//         };
//     }

//     logMousePos = (e:MouseEvent) =>{
//         this.setState({x:e.clientX, y:e.clientY})
//     }

//     componentDidMount() {
//       window.addEventListener('mousemove', this.logMousePos)
//     }

//     //Cleans up the mouse listener
//     componentWillUnmount() {
//       window.removeEventListener('mousemove',this.logMousePos)
//     }

//     public render() {
//         return (
//             <div>
//                 X - {this.state.x} Y - {this.state.y}
//             </div>
//         );
//     }
// }



// Using the functional implementation (with hooks)

function UseEffectDemo4() {

    const [x, setX] = useState(0);
    const [y, setY] = useState(0);

    const logMousePos = (e:MouseEvent) =>{
        setX(e.clientX);
        setY(e.clientY);
    }

    //By adding a empty array to the dependencies use effect will on get called once
    useEffect(()=>{
        console.log('Use effect Called');
        window.addEventListener('mousemove', logMousePos)
        
        //Return a function to be called when unmounted (cleanup code should be placed here)
        return  () => {window.removeEventListener('mousemove',logMousePos)}
    },[]);

    return (
        <div>
            X : {x} Y : {y}
        </div>
    );
}
export default UseEffectDemo4;