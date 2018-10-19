import React, { Component } from 'react';
import FormSubmit from '../FormSubmit';
import axios from 'axios';
import Header from '../Header';

class JobPage extends Component {
    state = {
        jobs: [],
        title:'',
        body:''
    }

    
    grabJobs = jobs => {
        axios.get(`http://localhost:5000/api/jobs`)
        .then(res => {
            console.log(res.data)
                this.setState({
                    jobs: res.data
                })
            })
    }


    componentDidMount() {
        this.grabJobs();
    }

    
    sendJobs = jobs => {
        axios.post(`http://localhost:5000/api/jobs`, this.state.title && this.state.body)

    }



    // addToThread = submittedThread => {
    //     let newThread = [...this.state.threads, submittedThread];
    //     this.setState({
    //         threads: newThread
    //     })
    // }

    render() {



        return ( 
            <div>
                <Header />
            <div className="row" id="container">
                <div style={{width: 1200}}id="threadBox">
                    <h1>Jobs</h1>
                    <table className= "table">
                        <thead>

                        </thead>
                        <tbody>
                            {this.state.jobs.map(j => {
                                return(
                                    <div
                                    className="card job-card">
                                        <h2
                                        className="card-title">{j.position_title}</h2>
                                        <h3>Company: {j.company_name}</h3>
                                        <h3>Position Type: {j.employment_type}</h3>
                                    </div>
                                )
                            })}
                        </tbody>
                    
                    </table>
                    {/* map out all the threads according to the submissions. 
                    each thread should be clickable */}
                    {/* <div className= 'threadBox'></div> */}
                </div>
                <div className="col-md-4" id="formBox">
                    <FormSubmit 
                    sendJobs = {this.props.sendJobs}/>
                    
                </div>
            </div>
            </div>

        );
    }
}



export default JobPage;