import React from 'react'
import "./Carrousel.css"
import { Link } from 'react-router-dom'

export default props => 

<div className="gridContainer">

  <div className="lateralCol">
    <Link to={props.leftArrowLink}>
      <i className="arrow left" title={props.leftArrowTitle}></i>
    </Link>
  </div>

  <div className="content">{props.content}</div>

  <div className="lateralCol">
    <Link to={props.rightArrowLink}>
      <i className="arrow right" title={props.rightArrowTitle}></i>
    </Link>
  </div>

</div>
