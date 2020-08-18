import React, { Component } from 'react'
import './Login.css'

export default class Login extends Component {

    constructor(props) {
        super(props)
        this.registerBtn = this.registerBtn.bind(this);
        this.isRegister = false;
        this.title = "Login"
    }

    registerBtn() {
        this.isRegister = !this.isRegister;
        this.title = this.isRegister ? 'Register New User' : 'Login';
        this.setState({isRegister: this.isRegister, title: this.tile})
    }

    render () {
        return (
            <div>
                <h1>{this.title}</h1>
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