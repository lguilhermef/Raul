import React, { useState } from 'react'
import './Register.css'
import axios, { AxiosResponse } from 'axios'
import { REGISTER_RAULUSER_URL } from '../../Constants/Constants'
import { NewRaulUserData } from '../../Types/Types'
import { setCurrentUser } from '../Authentication'



export const Register = () => {

    const [username, setUsername] = useState<string>("");
    const [password, setPassword] = useState<string>("");

    let newUser: NewRaulUserData = {
        username: username,
        password: password,
    };

    const registerUser = () => {
        
        axios({
            method: "post",
            url: REGISTER_RAULUSER_URL,
            data: newUser

        }).then((resp: AxiosResponse) => {

            if (resp.data) {
                setCurrentUser(resp.data);
            };
        })
    };

    return (
        <>
            <div className="header">
            </div>

            <div className="formContainer">
                <div className="form">
                    <h1 className="cardTitle">Register</h1>
                    <input className="registerInput" type="password" placeholder="Password" onChange={event => setPassword(event.target.value)}></input>
                    <input className="registerInput" type="text" placeholder="Username" onChange={event => setUsername(event.target.value)}></input>
                    <div className="btnContainer">
                        <button onClick={() => registerUser()}>Register</button>
                    </div>
                </div>
            </div>

        </>
    );
}