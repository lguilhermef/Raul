import React from 'react'
import "./Carrousel.css"
import { Link } from 'react-router-dom'

export default props => 

<div className="gridContainer">

  <div className="cola">
        <Link to="/age">
          <i className="arrow left"></i>
        </Link>
    </div>
  <div className="colb">Season</div>
  <div className="colc">
      <Link to="/competition">
        <i className="arrow right"></i>
      </Link>
  </div>
</div>
