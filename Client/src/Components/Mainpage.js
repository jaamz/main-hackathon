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
                <div className="imageFront" style={{backgroundColor: '#4d4d4d', textAlign: "center", color: 'white'}}>
                <h2>Redwood Alumni</h2>
                </div>
                <div className="box1">Jobs</div>
                {/* <img className= "imageFront" src="https://preview.ibb.co/dru6O0/cell-phone-close-up-contemporary-905873.jpg"/> */}
                <div className="centered">Centered</div>
                </div>
                
                <div className="row">
                    <div className="box2"></div>
                    {/* <img className="imageFront" src= "https://preview.ibb.co/fvht30/adult-agreement-beard-541522.jpg" />
                    <div className="centered">Centered</div> */}
                    <div className="box3"></div>
                    {/* <img className= "imageFront" src= "https://images.pexels.com/photos/7075/people-office-group-team.jpg?" />
                    <div className="centered">Centered</div> */}

                </div>
                </div>
                
            
        );
    }
}

export default MainPage;