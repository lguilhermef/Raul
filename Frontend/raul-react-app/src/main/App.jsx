import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import 'font-awesome/css/font-awesome.min.css'
import React, { Component } from 'react'
import { HashRouter } from 'react-router-dom'
import Login from "../components/Login/Login"
import Home from "../components/Home/Home"
import Dashboard from "../components/Dashboard/Dashboard"

const loginUrl = "";
let isLoggedIn = true;

export default class App extends Component {

    isLoggedIn  = { ...isLoggedIn};

    constructor(props) {
        super(props)
        this.login = this.login.bind(this);
    }

    login () {
        isLoggedIn = true;
        this.setState({isLoggedIn});
    }

    render () {
        if (isLoggedIn) {
                    
            return ( 
                <HashRouter>
                    <div className="App">
                        <Dashboard className="dashboard"/>
                    </div>
                </HashRouter>
                    )
        } else {

            return (
                <div>
                <Login className="login" login={this.login}/>
                </div>
            )
        }
    }
}
/*        if (isLoggedIn) {
            
            return ( 
                <HashRouter>
                    <div className="App">
                        App
                    </div>
                </HashRouter>
            )
        } else {

            return (
                <div>
                    <Login login={this.login}/>
                </div>
            )
        }*/