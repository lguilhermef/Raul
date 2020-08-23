import React from 'react'
import './Header.css'
import ComptSelector from './ComptSelector/ComptSelector'

export default props =>
    <div className="header">
        <ComptSelector setCompetition={props.setCompetition} className="compts"/>
        <button className="oldBtn" onClick={e => this.defineAction("cal")}>Calendar</button>
        <button className="oldBtn" onClick={e => this.defineAction("ngame")}>Next Game</button>
        <button className="oldBtn" onClick={e => this.defineAction("class")}>Classification</button>
    </div>