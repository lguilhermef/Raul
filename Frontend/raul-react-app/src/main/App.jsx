import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import 'font-awesome/css/font-awesome.min.css'
import React, { Component } from 'react'
import { HashRouter } from 'react-router-dom'
import Login from "./Auth/Login/Login"
import Raul from './Raul/Raul'

let isLoggedIn = false;

const universe = {
    id: 1,
    history: "",
    creationDate: null
}

const raulUser = {
    username: "Luís",
    rlFavTeam: "F.C. Porto",
    pesFavTeam: "Club Atlético de Madrid",
    rivalTeam: "",
    mediaFavTeam: "Club Atlético de Madrid",
    mediaRilvarTeam: "Chelsea F.C.",    
    favPlayerId: null,
}

export default class App extends Component {

    isLoggedIn  = { ...isLoggedIn};

    constructor(props) {
        super(props)

        this.state = {

            user: raulUser,
            universe: universe,
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
                    <div className="app">
                        <Raul className="dashboard" user={this.state.user} universe={this.state.universe}/>
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