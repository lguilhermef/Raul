import React, { Component } from 'react'
import './Login.css'
import axios from 'axios'

const apiURL = "https://localhost:44384/api/auth/login";

const raulUser = {
    username: "",
    rlFavTeam: "",
    pesFavTeam: "",
    rivalTeam: "",
    mediaFavTeam: "",
    mediaRilvarTeam: "",
    favPlayerId: null,
}

const loginData = {
    username: "",
    password: ""
}

export default class Login extends Component {

    constructor(props) {
        super(props)

        this.state = {
            
            isRegister: false,
            title: "Login",
            loginData: {...loginData},
            loggedUser: {...raulUser}
        }

        this.registerBtn = this.registerBtn.bind(this);
        this.postLoginData = this.postLoginData.bind(this);
    }

    updateField(event) {
        const loginData = this.state.loginData;
        loginData[event.target.name] = event.target.value;
        this.setState({ loginData })
    }

    postLoginData () {
        axios({
            method: 'post',
            url: apiURL,
            data: this.state.loginData
          }).then(resp => {
              this.state.loggedUser = resp.data
          })
    }

    registerBtn() {
        
        this.test();
        this.state.title = this.state.isRegister ? 'Register New User' : 'Login';
        this.setState({isRegister: !this.state.isRegister, title: this.state.title})
    }

    render () {
        return (
            <div>
                <h1>{this.state.title}</h1>
                <label>User</label>

                <input type="text" className="form-control"
                name="username" value={this.state.loginData.username}
                placeholder="Insert username..."
                onChange={e => this.updateField(e)}></input>

                <label>Password</label>
                <input type="text" className="form-control"
                name="password" value={this.state.loginData.password}
                placeholder="Insert password..."
                onChange={e => this.updateField(e)}></input>

                <button className="cbutton" onClick={this.postLoginData()}>Login</button>
                {/*<button className="cbutton" onClick={this.registerBtn}>Register</button>*/}
            </div>
        )
    }

}