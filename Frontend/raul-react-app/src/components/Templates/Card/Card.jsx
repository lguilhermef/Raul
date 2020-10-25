import React from 'react'
import './Card.css'

export default props =>
    <div className="cardContainer">
        {props.renderContent()}
    </div>