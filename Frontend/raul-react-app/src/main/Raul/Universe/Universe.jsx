import React from 'react'
import './Universe.css'
import { Link } from 'react-router-dom'

export default props => 
    <div>
        Universe
        <Link to="/age">
            <button className="oldBtn">age</button>
        </Link>
    </div>