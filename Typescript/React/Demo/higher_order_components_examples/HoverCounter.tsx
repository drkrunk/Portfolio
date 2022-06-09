import * as React from 'react';
import withCounter, { InjectedProps } from './WithCounter';

export interface IHoverCounterProps {
    count: number;
}

class HoverCounter extends React.Component<IHoverCounterProps & InjectedProps> {

    public render() {

        //Destructure props 
        const { count, incrementCount } = this.props;

        return (
            <div>
                <button onMouseOver={incrementCount}>Hovered {count} times.</button>
            </div>
        );
    }
}
export default withCounter(HoverCounter);
