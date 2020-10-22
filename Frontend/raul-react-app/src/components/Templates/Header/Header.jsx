import React from 'react'
import './Header.css'

import { Link } from 'react-router-dom'
import ComptSelector from './ComptSelector/ComptSelector'

export default props =>
    <div className="header">
        Welcome home, ## <strong>{props.user.username}</strong> ## 
        <ComptSelector universe={props.universe} setCompetition={props.setCompetition} setBanner={props.setBanner} className="compts"/>

        <button className="oldBtn" onClick={() => props.setPressedBtn("calendar")}>Calendar</button>

        <button className="oldBtn" onClick={() => props.setPressedBtn("nextGame")}>Next Game</button>

        <Link to="/classification">
            <button className="oldBtn">Classification</button>
        </Link>
    </div>