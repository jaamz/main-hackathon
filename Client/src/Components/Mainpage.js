import React, { Component } from 'react';
import Modal from './Modal';



class MainPage extends Component {
    state = {}

    render() {
        return (
            <div className="container">
                <div className="header"><img src='https://image.ibb.co/gc51O0/red.png' />
                <button className="btn btn-link">About Us</button> 
                <button className="btn btn-link" data-toggle="modal" data-target="#loginModal">Login</button>
                <button className="btn btn-link" data-toggle="modal" data-target="#signupModal">Sign Up</button>
                <Modal/>
                </div> 
                <div className="row">  
                <div className="col-md-4">
                    <img className= "imageFront" src="https://images.pexels.com/photos/905873/pexels-photo-905873.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"/>
                    <div classname="imgbox" style={{backgroundColor: '#e01e4d', color: 'white'}}>
                    Looking for Jobs?
                    asdf
                    assdf
                    asdf
                    </div>
                </div>
                <div className="col-md-4">
                    <img className= "imageFront" src= "https://images.pexels.com/photos/7075/people-office-group-team.jpg?auto=compress&cs=tinysrgb&h=650&w=940" />
                    <div classname="imgbox" style={{backgroundColor: '#e01e4d', color: 'white'}}>
                    Interviews
                    </div>
                </div>
                <div className="col-md-4">
                    <img className="imageFront" src= "https://images.pexels.com/photos/541522/pexels-photo-541522.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260" />
                    <div classname="imgbox" style={{backgroundColor: '#e01e4d', color: 'white'}}>
                    Project Collaborations
                    </div>
                </div>
                </div>
            </div>
        );
    }
}

export default MainPage;