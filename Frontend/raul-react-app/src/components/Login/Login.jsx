import React, { Component } from 'react'
import './Login.css'
import axios from 'axios'

const apiURL = "https://localhost:44384/api/auth/login";

export default class Login extends Component {

    constructor(props) {
        super(props)

        this.state = {
            
            isRegister: false,
            title: "Login"
        }

        this.registerBtn = this.registerBtn.bind(this);
        this.test = this.test.bind(this);
    }

    registerBtn() {
        
        this.test();
        this.state.title = this.state.isRegister ? 'Register New User' : 'Login';
        this.setState({isRegister: !this.state.isRegister, title: this.state.title})
    }

    test () {
        axios({
            method: 'post',
            url: apiURL,
            data: {
              username: 'Fred',
              password: 'Flintstone'
            }
          });
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