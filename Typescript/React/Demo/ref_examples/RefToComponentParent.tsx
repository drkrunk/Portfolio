import * as React from 'react';
import RefToComponentElement from './RefToComponentElement';


class RefToComponentParent extends React.Component {

    //In order for react to create a ref to the object it must be a class component not a functional  
    componentRef: React.RefObject<RefToComponentElement>;

    constructor(props: any) {
        super(props);
        this.componentRef = React.createRef();
    }

    clickHandler = () => {
        this.componentRef.current?.focusInput();
    };

    public render() {
        return (
            <div>
                <RefToComponentElement ref={this.componentRef} />
                <button onClick={this.clickHandler}>Focus Input</button>
            </div>
        );
    }
}

export default RefToComponentParent;