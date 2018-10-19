import React, { Component } from 'react';
import FormSubmit from '../FormSubmit';

class JobPage extends Component {


    render() {



        return ( 
            <div className="row" id="container">
                <div id="threadBox">
                    <h1>Jobs</h1>
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
                    <FormSubmit 
                    addToThread = {this.props.addToThread}/>
                    
                </div>
            </div>

        );
    }
}

export default JobPage;