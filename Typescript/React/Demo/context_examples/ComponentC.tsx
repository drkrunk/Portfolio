import React from "react";
import UserContext, { UserConsumer } from "./userContext";

/*
Context
-create context.
-provide a context value
-consume context value
*/

//In this example we will get data from the App component to ComponentC with property drilling.
export default class ComponentC extends React.Component {
    public render() {
        return (
            <UserConsumer>
            {
                (data)=>{
                    return <h1>{data.data} but rendered on ComponentC. {data.otherData}</h1>
                }
            }
            </UserConsumer>
        )
    }
}


