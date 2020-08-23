import React from 'react'
import "./Header.css"
import axios from 'axios'

const apiComptLstURL = "https://localhost:44384/api/competition/comptList";

function rCompSelector () {
    
    return (

        <select name="competitions" id="competitions">
            {rComptOptionsSelectorOpts()}
            {console.log(rComptOptionsSelectorOpts() + "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA")}
        </select>
        )
}

async function rComptOptionsSelectorOpts () {
    
    let key = 1;
    let opts = [];

     await axios["get"](apiComptLstURL)
        .then( resp => resp.data.map((c) => 
            opts.push(<option key={key++} value={c}>{c}</option>)
        ));

    return opts;
}

export default props =>

    <div className="homee">
        {rCompSelector()}
        <button className="oldBtn">Calendar</button>
        <button className="oldBtn">Next Game</button>
        <button className="oldBtn">Classification</button>
    </div>