import React, { useState } from 'react'
import './Login.css'
import {LoginData, RaulUser} from '../../Types/Types'
import { LOGIN_URL } from '../../Constants/Constants'
import axios, { AxiosResponse } from 'axios'
import { getCurrentUser, setCurrentUser } from '../Authentication'

interface Props {
    setLoginview: Function
};

export const Login = ({setLoginview} : Props): JSX.Element => {

    const [username, setUsername] = useState<string>("");
    const [password, setPassword] = useState<string>("");
    const [showErrorMessage, setShowErrorMessage] = useState<boolean>(false);

    let loginData: LoginData = {
        username: username,
        password: password
    };

    const loginUser = (data: LoginData): void => {

        const loginData: LoginData = {
            username: data.username,
            password: data.password
        }
    
        axios({
    
            method: "post",
            url: LOGIN_URL,
            data: loginData
    
        }).then((response: AxiosResponse) => {
            
            if (response.data) {
                setCurrentUser(response.data);
                let user: RaulUser = getCurrentUser();
            }

        }).catch(() => {
            setShowErrorMessage(true);            
        });
    };

    return (
        <>
            <div className="header">
            </div>

            <div className="formContainer">
                <div className="form">
                    <h1 className="cardTitle">Login</h1>
                    <input type="email" placeholder="Email" onChange={event => setUsername(event.target.value)}></input>
                    <input type="password" placeholder="Password" onChange={event => setPassword(event.target.value)}></input>
                    <div className="btnContainer">
                        <button onClick={() => loginUser(loginData)}>Login</button>
                    </div>
                     {/*<span className="linkBtn" onClick={() => setLoginview(false)}>Register</span>*/}
                </div>
            </div>
        </>
    );
}