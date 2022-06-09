import * as React from 'react';


//Using the React.forwardRef() you can forward the ref
const RefForwardingChild = React.forwardRef<HTMLInputElement, any>((props, ref) => {
  return <input type="text" ref={ref} />;
});

export default RefForwardingChild;
