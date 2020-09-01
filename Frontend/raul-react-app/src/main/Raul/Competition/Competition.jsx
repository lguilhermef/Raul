import React from 'react'
import './Competition.css'
import { Link } from 'react-router-dom'

export default props =>
    <div>
        Competition
        <Link to="/season">
            <button className="oldBtn">season</button>
        </Link>
    </div>