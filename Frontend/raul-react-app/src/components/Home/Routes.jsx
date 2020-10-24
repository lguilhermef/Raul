import React from 'react'
import { Switch, Route, Redirect } from 'react-router'

import Calendar from './Calendar/Calendar'
import Classification from './Classification/Classification'

export default props => 
    <Switch>
        <Route path="/calendar" component={() =>
             <Calendar currCompetition={props.currCompetition} user={props.user} universe={props.universe}/>}/>
             
        <Route path="/classification" component={Classification}/>
        <Redirect from='*' to='/calendar' />
    </Switch>