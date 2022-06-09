import * as React from 'react';

//This is an example of a functional component with properties. 
//Aka: Dumb / Presentational 
//Functional components preferably should be used over class components as they are (usually) stateless in nature.
//They are mainly responsible for UI.

//Properties of the component its wrapped in a interface so that we can use it as a type.
export interface IFunctionalExampleProps {
  exampleProperty: string;
}

//function StatelessExample(props: IStatelessExampleProps) {
//   return <h1>Hello {props.exampleProperty}</h1>
// }

//Fat arrow syntax from ES6
const StatelessExample = (props: IFunctionalExampleProps) => <h1>Hello {props.exampleProperty}</h1>;

//Default allows the name to changed on import in another file.
export default StatelessExample;