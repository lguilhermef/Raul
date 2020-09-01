import React, { Component } from 'react'
import './Login.css'
import axios from 'axios'

import Form from './Form/Form'
import FormButtons from './Buttons/FormButtons'

const apiURL = "https://localhost:44384/api/auth/login";

export default class Login extends Component {

    constructor(props) {
        super(props)

        this.state = {
            
            isRegister: false,
            title: "Login",
            loginData: {
                username: "",
                password: "",
            },
        }

        this.registerBtn = this.registerBtn.bind(this);
        this.updateField = this.updateField.bind(this);
    }

    updateField(event) {
        const loginData = this.state.loginData;
        loginData[event.target.name] = event.target.value;
        this.setState({ loginData })
    }

    registerBtn() {

        this.state.title = this.state.isRegister ? 'Register New User' : 'Login';
        this.setState({isRegister: !this.state.isRegister, title: this.state.title})
    }

    render () {
        return (
            <div>
                <h1>{this.state.title}</h1>
                <Form updateField={this.updateField} username={this.state.loginData.username} password={this.state.loginData.password}/>
                <FormButtons loginData={this.state.loginData} login={this.props.login}/>
            </div>
        )
    }
}