import * as React from 'react';

//This is an example of a functional stateful component.
//Aka: Smart / Container
//More feature rich
//Maintain a their own state
//Better for complex UI logic
//Provide lifecycle hooks.

//Lifecycle Methods
//Mounting called when created and inserted in to DOM
//--ctor, getDerivedStateFromProps, render, and componentDidMount

//Updating called when re-rendered (changes to props and state) 
//--getDerivedStateFromProps, shouldComponentUpdate, render, getSnapshotBeforeUpdate, and componentDidUpdate

//UnMounting called when being removed from DOM
//--componentWillUnmount

//Error Handling when there is an error in during (rendering, lifecycle method, constructor of a child) 
//--getDerivedStateFromError and componentDidCatch

//Props are immutable and cannot be changed once defined when passed in.
export interface IClassExampleProps {
    exampleProperty: string;
}

//State can be changed and are useful for data that changes over time.
//State is privately maintained in the class
export interface IClassExampleState {
    exampleState: string;
}

class ClassExample extends React.Component<IClassExampleProps, IClassExampleState> {

    //Common way doing a constructor by passing in the props of the component 
    constructor(props: IClassExampleProps) {
        super(props);

        this.state = {
            exampleState: ''
        };
    }

    //stateful components must have a render function that returns HTML code.
    public render() { 
        return <h1> Hello {this.props.exampleProperty} </h1>
    }
}

//Default allows the name to changed on import in another file.
export default ClassExample;