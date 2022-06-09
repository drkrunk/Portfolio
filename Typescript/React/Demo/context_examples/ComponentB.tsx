import React from "react";
import ComponentC from "./ComponentC";
import UserContext from "./userContext";

//In this example we will get data from the App component to ComponentC with property drilling.
class ComponentB extends React.Component {


    static contextType = UserContext;

    public render() {
        return (
        <div>
             Context from componentB: {this.context.data}. {this.context.otherData}
            <ComponentC />
        </div>
        );
    }
}
//Other way then static contextType
//ComponentB.contextType = UserContext;

export default ComponentB;