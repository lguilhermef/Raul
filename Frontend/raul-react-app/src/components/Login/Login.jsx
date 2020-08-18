import React, { Component } from 'react'
import './Login.css'


export default class Login extends Component {

    render () {
        return (
            <div>
                <button onClick={this.props.login}>Click to Login</button>
            </div>
        )
    }

}