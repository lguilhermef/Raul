import React from 'react'
import './Banner.css'
import AsciiRenderer from './AsciiRenderer'

export default props =>
    <div className="banner">
        <hr className="hru"></hr>
        <AsciiRenderer bannerWord={props.bannerWord}/>
        <hr className="hr"></hr>
    </div>