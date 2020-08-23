import React from 'react'
import './Calendar.css'

export default props =>
    <div className="calendar">
           <p>António vs Luís</p>
           <li> Jornada 01 - Pote B:  <strong>Fiorentina</strong> 1 x 1 <strong> West Ham</strong></li>
           <li> Jornada 02 - Pote A:  <strong>Manchester City</strong> 1 x 2 <strong> Juventus </strong></li>
           {props.currCompetition}
    </div>