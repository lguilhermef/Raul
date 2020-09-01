import React from 'react'
import { Switch, Route, Redirect } from 'react-router'

import Universe from './Universe/Universe'
import Age from './Age/Age'
import Season from './Season/Season'
import Competition from './Competition/Competition'

export default props => 
    <Switch>
        <Route path="/universe" component={() => 
            <Universe/>}/>

        <Route path="/age" component={() => <Age setBanner={props.setBanner}/>}/>

        <Route path ="/season" component={() => <Season setBanner={props.setBanner}/>}/>

        <Route path ="/competition" component={Competition}/>        
        <Redirect from='*' to='/season' />
    </Switch>