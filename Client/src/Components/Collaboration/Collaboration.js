import React, { Component } from 'react';
import FormSubmit from '../FormSubmit';
import axios from 'axios';
import Header from '../Header';

class Collaboration extends Component {
    state = {
        collaborations: []
    }


    grabCollab = collab => {
        axios.get(`http://localhost:5000/api/collaboration`)
            .then(res => {
                this.setState({
                    collaborations: res.data
                })
            })
    }
    componentDidMount() {
        this.grabCollab();
    }

    render() {
        return (
            <div>
                <Header /> 
                
            <div className="row" id="container">
            
                <div className="col-md-8" id="threadBox">
                    <h1>Project Collaboration</h1>
                    <table className="table">
                        <thead>

                        </thead>
                        <tbody>
                            {this.state.collaborations.map( c => {
                                return(
                                    <div className="card job-card">
                                        <h2>{c.collaboration_title}</h2>
                                        <h3>{c.appuser.username}</h3>
                                        <h3>{c.collaboration_body}</h3>
                                    </div>
                                )
                            })}
                        </tbody>

                    </table>

                </div>
                <div className="col-md-4" id="formBox">
                    <div>
                        <FormSubmit
                            addToThread={this.props.addToThread} />
                    </div>
                </div>
            </div>
            </div>
        );
    }
}

export default Collaboration;