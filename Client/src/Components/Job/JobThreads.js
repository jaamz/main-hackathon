import React, { Component } from 'react';


class JobThreads extends Component {
    state = {

    }
    render() {
        return (
            <div
                className="row"
                id="container">
                <div id="threadBox">
                    <h1>Job Threads</h1>
                    <table>
                        <thead>

                        </thead>
                        <tbody
                        className="thread-container">
                            <tr
                            className="thread-posting">
                                This is a thread that will have jobs
                            </tr>
                            <tr>Job opening in Tokyo, Japan for front-end developer!</tr>
                            <tr>Sample sample sample sample sample</tr>
                            <tr>Sample sample sample sample sample</tr>
                            <tr>Sample sample sample sample sample</tr>
                            <tr>Sample sample sample sample sample</tr>
                            <tr>Sample sample sample sample sample</tr>
                            
                        </tbody>
                    </table>
                </div>
            </div>
        );
    }
}

export default JobThreads;