import React, { Component } from 'react';
import JobPage from './Components/JobPage';
import Collaboration from './Components/Collaboration';
import FormSubmit from './Components/FormSubmit';
// import InterviewPage from './Components/InterviewPage';
// import Mainpage from './Components/Mainpage'
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

        <Collaboration />
        {/* <JobPage
          addToThread ={this.addToThread}
          thread= {this.state.thread} /> */}


      </div>
    );
  }
}

export default App;
