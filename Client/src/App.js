import React, { Component } from 'react';
import JobPage from './Components/JobPage';
import FormSubmit from './Components/FormSubmit';
import InterviewPage from './Components/InterviewPage';
import Mainpage from './Components/Mainpage';
import './App.css';

class App extends Component {
  state= {
    threads: []
  }

   addToThread = submittedThread => {
        let newThread = [...this.state.threads, submittedThread];
        this.setState({
            threads: newThread
        })
        console.log(this.state.threads);
    }


  render() {
    return (
      <div className="App">
        
          
          {/* <JobPage
          addToThread ={this.addToThread}
          thread= {this.state.thread} /> */}
          {/* <InterviewPage /> */}
          <Mainpage />
          
        
      </div>
    );
  }
}

export default App;
