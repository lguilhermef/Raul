import React from 'react'
import './Banner.css'
import AsciiRenderer from './AsciiRenderer'

export default props =>
    <div>
        <AsciiRenderer currCompetition={props.currCompetition}/>
    </div>