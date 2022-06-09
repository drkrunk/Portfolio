import * as React from 'react';
import ConditionalTrueChild from './Conditional1Child';
import ConditionalFalseChild from './Conditional2Child';


export interface IConditionalParentState {
    shouldRender: boolean;
}

export default class ConditionalParent extends React.Component<{}, IConditionalParentState> {
    constructor(props: any) {
        super(props);

        this.state = {
            shouldRender: true
        };
    }

    public render() {

        //Way 1 of rendering conditionally
        // if (this.state.shouldRender)
        //     return <ConditionalTrueChild />;
        // else
        //     return <ConditionalFalseChild />;

        //way 2 Element Variables
        // let condition = this.state.shouldRender

        // if(condition) return <ConditionalTrueChild />;
        // else return <ConditionalFalseChild />;

        //Way 3 of rendering conditionally turnery approach (preferred way)
        return(
            this.state.shouldRender? <ConditionalTrueChild /> : <ConditionalFalseChild />
        );

        //Way 4 short circuit operator if the tag should no be rendered.
        //return this.state.shouldRender && <ConditionalTrueChild />

    }
}
