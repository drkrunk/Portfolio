import * as React from 'react';
import withCounter, { InjectedProps } from './WithCounter';


interface IClickCounterProps {
    count: number;
}

class ClickCounter extends React.Component<IClickCounterProps&InjectedProps> {

    public render() {

        //Destructure props 
        const { count, incrementCount } = this.props;

        return (
            <div>
                <button onClick={incrementCount} >Clicked {count} times.</button>
            </div>
        );
    }
}
export default withCounter(ClickCounter);
