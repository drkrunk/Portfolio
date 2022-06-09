import * as React from 'react';


//Use an object here pass multiple values.
const UserContext = React.createContext({data:'', otherData:'nothing'});

//Only descendants can consume from the provider
const UserProvider = UserContext.Provider;
const UserConsumer = UserContext.Consumer;

export{UserProvider, UserConsumer}

export default UserContext;