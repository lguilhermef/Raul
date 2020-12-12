import React, { useState } from 'react'
import {Login} from './Login/Login'
import {Register} from './Register/Register'
import { RaulUser } from '../Types/Types'
import { LocalStorage } from '../Enums/Enums'

export const getCurrentUser = (): RaulUser => {
    let storedUserJson = localStorage.getItem(LocalStorage.GET_USER);
    return storedUserJson != null ? JSON.parse(storedUserJson) : null;
};

export const setCurrentUser = (user: RaulUser): void => {
    localStorage.setItem(LocalStorage.GET_USER, JSON.stringify(user))
    window.location.reload();
};

export const logout = (): void => {
    localStorage.removeItem(LocalStorage.GET_USER);
    window.location.reload();
};

export const Authentication = (): JSX.Element => {

    const [showLoginView, setLoginView] = useState<boolean>(true);

    const handleChange: Function = (value:boolean): void => {
        setLoginView(value);
    };

    return (
        <div className="dashboardContainer">
            {showLoginView ? <Login setLoginview={handleChange}/> : <Register/>}
        </div>
    );
}