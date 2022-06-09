import * as React from 'react';
import Person from './Person';


function PersonList() {
    //Test objects
    const Men = [
        { name: 'Tim', age: 20, mood: 'happy' },
        { name: 'Bob', age: 54, mood: 'sad' },
        { name: 'Fred', age: 20, mood: 'angry' }
    ];

    // Method without a person component.
    // const people = Men.map(person => <h2>{person.name} is a {person.age} year old {person.mood} man.</h2>);
    // return <div>{people}</div>

    //(Preferred way) Break into a smaller component. Key is important. 
    //React uses the key to keep track of what has changed and only updates what it need to 
    //Although index works as a key in this example index is not always useful as a key.
    //Index should only be used as a key it is a static list 
    const people = Men.map((person, index) => <Person key={index} person = {person} ></Person>);
    return <div>{people}</div>
    
}

export default PersonList;
