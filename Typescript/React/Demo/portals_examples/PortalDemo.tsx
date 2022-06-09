import React from 'react';
import ReactDOM from 'react-dom';

//Portals are great for modals and popups and bubbles event as if it was child of the root
const PortalDemo =()=> {
    const element: HTMLElement = document.getElementById("portal-root") as HTMLElement;
    const portalDemoElement = ReactDOM.createPortal(<h1>Portal Demo</h1>,element);
    return portalDemoElement;
}

export default PortalDemo;