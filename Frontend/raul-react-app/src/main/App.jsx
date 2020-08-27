import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import 'font-awesome/css/font-awesome.min.css'
import React, { Component } from 'react'
import { HashRouter } from 'react-router-dom'
import Login from "../components/Login/Login"
import Dashboard from "../components/Dashboard/Dashboard"

const loginUrl = "";
let isLoggedIn = false;
const raulUser = {
    username: "",
    rlFavTeam: "",
    pesFavTeam: "",
    rivalTeam: "",
    mediaFavTeam: "",
    mediaRilvarTeam: "",
    favPlayerId: null,
}

export default class App extends Component {

    isLoggedIn  = { ...isLoggedIn};

    constructor(props) {
        super(props)

        this.state = {

            user: null,
            selectedUniverse: 0,
        }

        this.login = this.login.bind(this);
    }

    login (user) {

        if (user != null) {
            isLoggedIn = true;
            this.setState({isLoggedIn, user});
        }
    }

    render () {
        if (isLoggedIn) {
                    
            return ( 
                <HashRouter>
                    <div className="App">
                        <Dashboard className="dashboard" user={this.state.user}/>
                    </div>
                </HashRouter>
                    )
        } else {

            return (
                <div className="login">
                    <Login login={this.login}/>
                </div>
            )
        }
    }
}