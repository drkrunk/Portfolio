import * as React from 'react';
//Memos are to functional components as PureComponents are to class components 


function MemoExample() {
    return <div> MemoComponent</div>;
}

export default React.memo(MemoExample);