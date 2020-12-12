import React, { useEffect, useState } from 'react';
import { BrowserRouter } from 'react-router-dom'
import './App.css';
import {Authentication, getCurrentUser} from './Authentication/Authentication'
import {Dashboard} from './Views/Dashboard/Dashboard'
import { RaulUser } from './Types/Types'

export const App = (): JSX.Element => {

  const [currentUser, setCurrentUser] = useState<RaulUser>();

  useEffect(() => {

    const user: RaulUser = getCurrentUser();

    if (user) {
      setCurrentUser(user);
    }

  }, []);

  return (
    <BrowserRouter>
      <div className="App">
        {currentUser ? (<Dashboard/>) : (<Authentication/>)}
      </div>
    </BrowserRouter>
  );
};