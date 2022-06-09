import * as React from 'react';

export interface IAppProps {}

export interface IAppState {}

export default class App extends React.Component<IAppProps, IAppState> {
	constructor(props: IAppProps) {
		super(props);
		console.log('test');
		this.state = {};
	}

	public render() {
		return <div></div>;
	}
}
