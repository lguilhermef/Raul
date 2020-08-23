import React from 'react'
import { Switch, Route, Redirect } from 'react-router'

import Calendar from './Calendar/Calendar'
import NextGame from './NextGame/NextGame'
import Classification from './Classification/Classification'

export default props => 
    <Switch>
        <Route path="/calendar" component={Calendar} />
        <Route path="/nextgame" component={NextGame}/>
        <Route path="/classification" component={Classification}/>
        <Redirect from='*' to='/calendar' />
    </Switch>