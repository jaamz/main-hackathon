import React, { Component } from 'react';
import { Link } from 'react-router-dom';

class Header extends Component {
    state = {  

    }
    render() { 
        return (  
            <div>
                <img style={{width: 120}} src='https://image.ibb.co/gc51O0/red.png' />
                <Link to="/"><button className='btn btn-link'> Home </button></Link>
            
            </div>
        );
    }
}
 
export default Header;