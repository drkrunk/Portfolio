import * as React from 'react';


class RefToComponentElement extends React.Component {

    inputRef: React.RefObject<HTMLInputElement>;
    
    constructor(){
        super({})
        this.inputRef = React.createRef();
    }

    focusInput(){
        this.inputRef.current?.focus();
    }
    
    public render() {
        return  <input type="text" ref={this.inputRef}/>;
    }
}
export default RefToComponentElement;