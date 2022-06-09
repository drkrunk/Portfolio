import * as React from 'react';
import RefForwardingChild from './RefForwardingChild';

class RefForwardingParent extends React.Component {
    inputRef: React.RefObject<HTMLInputElement>;


    constructor(props: any) {
        super(props);
        this.inputRef = React.createRef();
    }

    clickHandler = () => {
        this.inputRef.current?.focus();
    };

    public render() {
        return (
            <div>
                <RefForwardingChild ref={this.inputRef} />
                <button onClick={this.clickHandler}>Focus Input</button>
            </div>
        );
    }
}

export default RefForwardingParent;
