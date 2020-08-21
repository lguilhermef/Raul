import React, { Component } from 'react'
import './Home.css'

import axios from 'axios'

const apiComptLstURL = "https://localhost:44383/api/competition/comptList";

const initialState = {
    comptList: [],
    currentCompetiton: "Choose One"
};

export default class Home extends Component {

    state = {...initialState}

    constructor(props) {
        super(props)

        this.getCompetitions = this.getCompetitions.bind(this);
        this.rComptOptions = this.rComptOptions.bind(this);
        this.rComptOptionsSelectorOpts = this.rComptOptionsSelectorOpts.bind(this);
    }

    componentWillMount () {
        this.getCompetitions();
    }

    getCompetitions () {

        axios["get"]("https://localhost:44383/api/competition/comptList")
            .then(resp => {
                this.setState({comptList: resp.data});
            });
    }

    rComptOptionsSelectorOpts () {
        let key = 1;
        return this.state.comptList.map((c) =>
            <option key={key++} value={c}>{c}</option>
            )
    }

    rComptOptions () {
        
        return (
        <select name="competitions" id="competitions">
            {this.rComptOptionsSelectorOpts()}
        </select>
        )
    }


    render () {
        return (
            <div>
                <h1>Home</h1>
                    <h2>Select a Competition :</h2>
                    {this.rComptOptions()}
            </div>
        )
    }
}