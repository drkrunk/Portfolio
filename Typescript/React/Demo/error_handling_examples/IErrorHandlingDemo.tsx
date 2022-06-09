import * as React from 'react';

function ErrorHandlingDemo({ throwError }: any) {

  if (throwError) { throw new Error('An error occurred because I wanted it to.'); }

  return (
    
      <h1>The content</h1>
    
  );
}

export default ErrorHandlingDemo;
