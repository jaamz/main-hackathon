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

  // renderHelper = path => {
  //   switch (path) {
  //     case HOME: 
  //     return <MainPage />
  //     case JOB: 
  //     return 
  //     case INTERVIEW:
  //     return
  //     case COLLABORATION:
  //     return
  //     default:
  //     return <h1>Not found</h1>
  //   }
  // }

  render() {
    return (
      <div className="App">
          <Switch>
            <Route exact path = '/' render ={(renderProps) => <MainPage {...renderProps} />} />
            <Route path = "/Jobs" render={(renderProps) => <JobPage {...renderProps} />} />
            <Route path = "/Interview" render ={(renderProps) => <InterviewPage {...renderProps} />} />
            <Route path = "/Collaboration" render={(renderProps) => <Collaboration {...renderProps} />} />
          </Switch>
          
        
      </div>
    );
  }
}

export default App;
