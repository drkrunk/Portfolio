import * as React from 'react';

function ColorsList() {
    const colors = ['red', 'green', 'blue'];
    const colorList = colors.map(color => <h2>{color}</h2>);
    return <div>{colorList}</div>;

}

export default ColorsList;