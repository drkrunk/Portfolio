import * as React from 'react';
import { ICounterRendererProps } from './Counter';

//Only holds the information for rendering
class ClickCounter extends React.Component<ICounterRendererProps> {

    public render() {
        //Destructure props 
        const { count, incrementCount } = this.props;

        return (
            <div>
                <button onClick={incrementCount as React.MouseEventHandler<HTMLButtonElement>} >Clicked {count} times.</button>
            </div>
        );
    }
}
export default ClickCounter;
