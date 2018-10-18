import React, { Component } from 'react';
import FormSubmit from './FormSubmit';

class JobPage extends Component {
    state = {
        threads:[],

    }

    componentDidMount() {
        this.props.grabThreads();
    }

    addToThread = submittedThread => {
        let newThread = [...this.state.threads, submittedThread];
        this.setState({
            threads: newThread
        })
    }

    render() {



        return ( 
            <div>
                <div>
                    <h1>Thread</h1>
                </div>
                <div>
                    <FormSubmit />
                </div>
            </div>

        );
    }
}



export default JobPage;