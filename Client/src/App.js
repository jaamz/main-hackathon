import React, { Component } from 'react';
import JobPage from './Components/JobPage';
import FormSubmit from './Components/FormSubmit';
import './App.css';
import axios from 'axios';

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
        
          
          <JobPage
          addToThread ={this.addToThread}
          thread= {this.state.thread} />
          
        
      </div>
    );
  }
}

export default App;
