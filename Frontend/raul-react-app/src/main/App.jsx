import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import 'font-awesome/css/font-awesome.min.css'
import React, { Component } from 'react'
import { HashRouter } from 'react-router-dom'
import Login from "../components/Login/Login"

const loginUrl = "";
let isLoggedIn = false;

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
                                App
                            </div>
                        </HashRouter>
                    )
                } else {

                    return (
                        <div>
                            <Login clogin={this.login}/>
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