import React, { Component } from 'react'
import './Home.css'

import axios from 'axios'

const apiComptLstURL = "https://localhost:44383/api/competition/comptList";

export default class Home extends Component {

    constructor(props) {
        super(props)

        this.currentCompetiton = "Unknown"
        this.comptList = [];

        this.getCompetitions = this.getCompetitions.bind(this);
        this.rComptOptions = this.rComptOptions.bind(this);
        this.rComptOptionsSelectorOpts = this.rComptOptionsSelectorOpts.bind(this);
    }

    getCompetitions () {

        axios["get"](apiComptLstURL)
            .then(resp => {
                this.comptList = resp.data;
            });
    }

    rComptOptionsSelectorOpts () {
        let key = 1;
        const cOptions = this.comptList.map((c) =>
            <option key={key++} value={c}>{c}</option>
        );
        return cOptions;
    }

    rComptOptions () {

        this.getCompetitions();
        

        return (
        <select name="competitions" id="competitions">
            <option value="League">League</option>
            <option value="Cup">Cup</option>
            {this.rComptOptionsSelectorOpts()}
        </select>
        )
        this.setState();
    }


    render () {
        return (
            <div>
                <h1>Home</h1>
                    <h2>Select a Competition :</h2>
                    <button onClick={this.rComptOptions}>API</button>
                    {this.rComptOptions()}
            </div>
        )
    }
}