import * as React from 'react';

//ErrorBoundary declares what happens to a component in case of a error so the whole page doesn't crash.
export interface IErrorBoundaryState {
    hasError:boolean
}

 class ErrorBoundary extends React.Component<{}, IErrorBoundaryState> {
  constructor(props:any) {
    super(props);

    this.state = {hasError : false}
  }

  static getDerivedStateFromError(error:Error){
      return {hasError:true}
  }

  componentDidCatch(error:Error, info:any){
    console.log(console.error(error, info));
  }

  public render() {
        return (this.state.hasError)? <h1>Error Has Happened</h1>:this.props.children
  }
}
export default ErrorBoundary