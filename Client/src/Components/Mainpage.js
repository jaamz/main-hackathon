import React, { Component } from 'react';
import Modal from './Modal';
import { Link } from 'react-router-dom';


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
                <h2 style={{padding: 30 }}>Red+</h2>
                <div>_________________________________</div>
                The exclusive central hub for Redwood students and Alumni.
                Students: Join message boards to collaborate, find the perfect jobs, and prep for the job interview.
                <div>_________________________________</div>
                </div>
                <Link to="/Jobs"><div className="box1">Jobs</div></Link>
                {/* <img className= "imageFront" src="https://preview.ibb.co/dru6O0/cell-phone-close-up-contemporary-905873.jpg"/> */}
                
                </div>
                
                <div className="row">
                    <Link to="/Collaboration"><div className="box2"></div></Link>
                    {/* <img className="imageFront" src= "https://preview.ibb.co/fvht30/adult-agreement-beard-541522.jpg" />
                    <div className="centered">Centered</div> */}
                    <Link to="/Interview"><div className="box3"></div></Link>
                    {/* <img className= "imageFront" src= "https://images.pexels.com/photos/7075/people-office-group-team.jpg?" />
                    <div className="centered">Centered</div> */}

                </div>
                </div>
                
            
        );
    }
}

export default MainPage;