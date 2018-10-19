import React, { Component } from 'react';
import FormSubmit from '../FormSubmit';
import axios from 'axios';


class InterviewPage extends Component {
state={
    thread:[]
}

componentDidMount(){
    this.grabInterviews();
}

grabInterviews = res => {
    axios.get(`http://localhost:5000/api/`)
    .then(res => {
        
            this.setState({
                thread: res.data
            })
        })
}

    render() {

        return ( 
            <div className="row" id="container">
                <div className="col-md-8" id="threadBox">
                    <h1>Interviews</h1>
                    <table className= "table">
                        <thead>

                        </thead>
                        <tbody>
                            <tr>this is going to map out threads</tr>
                            <tr>t row 2</tr>
                        </tbody>
                    
                    </table>
                    {/* map out all the threads according to the submissions. 
                    each thread should be clickable */}
                    {/* <div className= 'threadBox'></div> */}
                </div>
                <div className="col-md-4" id="formBox">
                    <div>
                    <FormSubmit 
                    addToThread = {this.props.addToThread}/>
                    </div>
                </div>
            </div>

        );
    }
}

export default InterviewPage;