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
        this.props.addToThread(this.state);
        this.setState({
            title:'',
            body:''
        })
    }






    render() {

        return (
            <div className="formContainer">
                <form
                onSubmit={this.onClick}>
                    <div >
                        <input
                        className="form-control"
                        value={this.state.title}
                        onChange={this.onTitleChange}
                        />
                        </div>
                        <div>
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