import React from 'react'
import { Switch, Route, Redirect } from 'react-router'

import Universe from './Universe/Universe'
import Age from './Age/Age'
import Season from './Season/Season'
import Competition from './Competition/Competition'
import Calendar from '../../components/Calendar/Calendar'

const competitione = {
    universeId: 1,
    comptName: "League",
    alias: "",
    history: "",
    rules: "",
    winnerId: null,
    edition: null,
    isOfficialCompetition: null
}

export default props => 
    <Switch>
        <Route path="/universe" component={() => 
            <Universe setUniverse={props.setUniverse} setBanner={props.setBanner} universe={props.universe} user={props.user}/>}/>

        <Route path="/age" component={() => <Age setBanner={props.setBanner}/>}/>

        <Route path ="/season" component={() => <Season setBanner={props.setBanner}/>}/>

        <Route path ="/competition" 
            component={() => <Competition 
                setBanner={props.setBanner} 
                universe={props.universe} 
                user={props.user} 
                currCompetition={props.currCompetition}
                pressedBtn={props.pressedBtn}/>}
        />    
        
        <Route path ="/calendar" component={() => <Calendar currCompetition={props.currCompetition} universe={props.universe}/>}/>     
        <Redirect from='*' to='/universe' />
    </Switch>