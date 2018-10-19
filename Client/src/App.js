import React, { Component } from 'react';
import JobPage from './Components/Job/JobPage';
import Collaboration from './Components/Collaboration/Collaboration';
import JobThreads from './Components/Job/JobThreads'
import FormSubmit from './Components/FormSubmit';
import InterviewPage from './Components/Interview/InterviewPage';
import Mainpage from './Components/Mainpage';
import './App.css';
import axios from 'axios';

class App extends Component {
  state = {
    threads: []
  }

  addToThread = submittedThread => {
    let newThread = [...this.state.threads, submittedThread];
    this.setState({
      threads: newThread
    })
    console.log(this.state.threads);
  }

  // CORS .NET 


  grabThreads = threads => {
    axios.get(`http://localhost:5000/`)
      .then(res => {
        this.setState({
          threads: res.data.map(x => x.threads)
        })
      })
  }

  render() {
    return (
      <div className="App">
        {/* <JobThreads /> */}
        
        {/* <Collaboration /> */}
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
