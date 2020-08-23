import React from 'react'
import './Banner.css'
import AsciiRenderer from './AsciiRenderer'

export default props =>
    <div className="banner">
        <hr className="hru"></hr>
        <AsciiRenderer currCompetition={props.currCompetition}/>
        <hr className="hr"></hr>
    </div>