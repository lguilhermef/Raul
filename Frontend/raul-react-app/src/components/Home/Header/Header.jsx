import React from 'react'
import './Header.css'

import { Link } from 'react-router-dom'
import ComptSelector from './ComptSelector/ComptSelector'

//Carregar num btn muda a selectedWord que se propaga até ao content do carrossel

export default props =>
    <div className="header">
        Welcome home, ## <strong>{props.user.username}</strong> ## 
        <ComptSelector universe={props.universe} setCompetition={props.setCompetition} className="compts"/>
        <Link to="/calendar">
            <button className="oldBtn">Calendar</button>
        </Link>

        <button className="oldBtn" onClick={() => props.setPressedBtn("nextGame")}>Next Game</button>

        <Link to="/classification">
            <button className="oldBtn">Classification</button>
        </Link>
    </div>