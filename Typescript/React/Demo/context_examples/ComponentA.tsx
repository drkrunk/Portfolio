import React from 'react';
import ComponentB from './ComponentB';


//In this example we will get data from the App component to ComponentC with property drilling.
export default class ComponentA extends React.Component {
    public render() {
        return <ComponentB />;
    }
}
