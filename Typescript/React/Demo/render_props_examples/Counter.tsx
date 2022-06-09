import * as React from 'react';

//The term "render prop" refers to a technique for sharing code between React components using a prop whose value is a function.
//This is similar to HOC as the logic is decoupled from the rendering

//The renders are passed as props to render the counter GUI.
//<Counter render={(count: number, incrementCount: Function) => <ClickCounter count={count} incrementCount={incrementCount} />} />

//The renderer must use this interface for typing
export interface ICounterRendererProps {
    incrementCount: Function,
    count: number;
}

interface ICounterProps {
    render: Function;
}

interface ICounterState {
    count: number;
}


//Only holds the logic for counting
class Counter extends React.Component<ICounterProps, ICounterState> {

    constructor(props: ICounterProps) {
        super(props);

        this.state = {
            count: 0
        };
    }

    //Get previous state and increments count by one
    incrementCount = () => {
        this.setState(prevState => {
            return { count: prevState.count + 1 };
        });
    };

    //Passes the rendering to another components rendering function
    public render() {
        return (
            <div>
                {this.props.render(this.state.count, this.incrementCount)}
            </div>
        );
    }
}
export default Counter;