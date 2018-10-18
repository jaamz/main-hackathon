import React, { Component } from 'react';
import JobPage from './Components/JobPage';
import './App.css';
import axios from 'axios';

class App extends Component {
  

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
        
          
          <JobPage />
        
      </div>
    );
  }
}

export default App;
