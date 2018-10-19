import React, { Component } from 'react';
import FormSubmit from '../FormSubmit';
import axios from 'axios';
import Header from '../Header';


class InterviewPage extends Component {
state={
    interview:[]
}

componentDidMount(){
    this.grabInterviews();
}

grabInterviews = res => {
    axios.get(`http://localhost:5000/api/interview`)
    .then(res => {
            this.setState({
                interview: res.data
            })
        })
}

    render() {

        return ( 
            <div>
                <Header />
            <div className="row" id="container">
                <div className="col-md-8" id="threadBox">
                    <h1>Interviews</h1>
                    <table className= "table">
                        <thead>

                        </thead>
                        <tbody>
                            <tr>
                            {this.state.interview.map(i => {
                                return(
                                    <div className="card job-card">
                                        <h3>
                                            {i.interview_title}
                                        </h3>
                                        <h3>User: {i.appuser.username}</h3>
                                        <h4>
                                            {i.interview_body}
                                        </h4>
                                    </div>
                                )
                            })}
                            </tr>
                        </tbody>
                    
                    </table>
                </div>
                <div className="col-md-4" id="formBox">
                    <div>
                    <FormSubmit 
                    addToThread = {this.props.addToThread}/>
                    </div>
                </div>
            </div>
            </div>

        );
    }
}

export default InterviewPage;