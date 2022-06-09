import * as React from 'react';

//Interface needed for typing in components that use WithCounter.
export interface InjectedProps {
    incrementCount(): void;
}

//P is a generic type takes a component in as an argument.
const withCounter = <P extends object>(WrappedComponent: React.ComponentType<P>) => {

    //Wraps component with new functionality from a new Component. 
    class WithCounter extends React.Component<P & InjectedProps, {count: number}>{

        constructor(props: any) {
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

        //Injects props to component
        render() {
            return <WrappedComponent
                {...this.props as P}
                incrementCount={this.incrementCount}
                count={this.state.count}
            />;
        }
    }

    //Returns an enhanced component 
    return WithCounter;
};

export default withCounter;
