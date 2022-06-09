import * as React from 'react';
import { ICounterRendererProps } from './Counter';

//Only holds the information for rendering
class HoverCounter extends React.Component<ICounterRendererProps> {

    public render() {
        //Destructure props 
        const { count, incrementCount } = this.props;

        return (
            <div>
                <button onMouseOver={incrementCount as React.MouseEventHandler<HTMLButtonElement>}>Hovered {count} times.</button>
            </div>
        );
    }
}
export default HoverCounter;
