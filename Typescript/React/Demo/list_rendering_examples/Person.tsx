import * as React from 'react';

//Example of functional component for the object list example
export default function Person ({person}:any) {
  return <h2>{person.name} is a {person.age} year old {person.mood} man.</h2>
}

