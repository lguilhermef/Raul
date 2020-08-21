import React, { Component } from 'react'
import './Login.css'

export default class Login extends Component {

    constructor(props) {
        super(props)

        this.state = {
            
            isRegister: false,
            title: "Login"
        }

        this.registerBtn = this.registerBtn.bind(this);
    }

    registerBtn() {
        
        this.state.title = this.state.isRegister ? 'Register New User' : 'Login';
        this.setState({isRegister: !this.state.isRegister, title: this.state.title})
    }

    render () {
        return (
            <div>
                <h1>{this.state.title}</h1>
                <label>User</label>
                <input type="text"></input>
                <label>Password</label>
                <input type="password"></input>
                <button className="cbutton" onClick={this.props.login}>Login</button>
                <button className="cbutton" onClick={this.registerBtn}>Register</button>
            </div>
        )
    }

}