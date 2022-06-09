import * as React from 'react';

//Very basic use of a ref
class RefDemo extends React.Component {
    //Creates a ref to the input field
    inputRef: React.RefObject<HTMLInputElement>;
    constructor() {
        super({});
        this.inputRef = React.createRef();
    }

    //Focus the input through its ref.
    componentDidMount(){
        this.inputRef.current?.focus();
        console.log(this.inputRef);
    }

    //Sets the ref to the input element.
    public render() {
        return <input type="text" ref={this.inputRef}/>;
    }
}
export default RefDemo;