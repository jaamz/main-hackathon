import React, {Component} from 'react';

class Modal extends Component {
        state = {  }
    
    render() { 
        return ( 
            <div>
        <div class="modal fade" id="loginModal" tabindex="-1" role="dialog" aria-labelledby="loginModalLabel" aria-hidden="true">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="loginModalLabel">Login</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">

                                <input className="form-control" placeholder="Username" />
                                <input type="password" className="form-control" placeholder="Password" />
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-secondary" >Login</button>
                                
                            </div>
                        </div>
                    </div>
                </div>


                <div class="modal fade" id="signupModal" tabindex="-1" role="dialog" aria-labelledby="signupModalLabel" aria-hidden="true">
                    <div class="modal-dialog" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="loginModalLabel">Sign Up</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">

                                <input className="form-control" placeholder="Username" />
                                <input type= "password" className="form-control" placeholder="Password" />
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-secondary" >Sign Up</button>
                                
                            </div>
                        </div>
                    </div>
                </div>

                </div>
         );
    }
}

 
export default Modal;

