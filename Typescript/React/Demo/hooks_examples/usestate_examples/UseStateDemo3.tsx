import React, { useState } from 'react';


//Use state with object
//The hook implementation of the a simple counter 
export default function CountHook() {
    const initName = {
        firstName: '',
        lastName: ''
    };
    const [name, setName] = useState(initName); //<= example of the useState hook.

    //Without ...name set name won't maintain the state for the other properties
    return (
        <form>
            <input type="text" value={name.firstName} onChange={e => setName({...name, firstName: e.target.value }) } />
            <input type="text" value={name.lastName} onChange={e => setName({...name, lastName: e.target.value }) } />
            <br/>
            Name: {name.firstName}   {name.lastName}
        </form>
    );
}
