import React from 'react'
import './Header.css'

import { Link } from 'react-router-dom'
import ComptSelector from './ComptSelector/ComptSelector'

export default props =>
    <div className="header">
        Welcome home, ## <strong>{props.user.username}</strong> ## 
        <ComptSelector setCompetition={props.setCompetition} className="compts"/>
        <Link to="/calendar">
            <button className="oldBtn">Calendar</button>
        </Link>
        <Link to="/nextgame">
            <button className="oldBtn">Next Game</button>
        </Link>
        <Link to="/classification">
            <button className="oldBtn">Classification</button>
        </Link>
    </div>