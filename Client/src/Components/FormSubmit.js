import React, { Component } from 'react';

class FormSubmit extends Component {
    state = {
        title: '',
        body: '',
    }

    onTitleChange = e => {
        this.setState({
            title: e.target.value
        })
    }

    onBodyChange = e => {
        this.setState({
            body:e.target.value
        })
    }

    onClick = e => {
        e.preventDefault();
        this.props.sendJobs();
        this.setState({
            title:'',
            body:''
        })
    }






    render() {

        return (
            <div className="formContainer">
            <h1 style={{textAlign: "center", color: "#516991"}}> Create a thread </h1>
                <form
                onSubmit={this.onClick}>
                    <div >
                        Title
                        <input
                        className="form-control"
                        value={this.state.title}
                        onChange={this.onTitleChange}
                        />
                        </div>
                        <div>
                            Message
                            <textarea 
                            className="form-control"
                            rows="5"
                            value={this.state.body}
                            onChange={this.onBodyChange}
                            />
                        </div>
                        <div>
                            <button 
                            className="btn btn-primary"
                            >Submit</button>
                    </div>
                </form>


            </div>
        );
    }
}

export default FormSubmit;