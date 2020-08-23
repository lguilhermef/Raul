import React, { Component } from 'react'
import './Home.css'
import League from '../Competitions/League/League'
import Cup from '../Competitions/Cup/Cup'

import axios from 'axios'

const apiComptLstURL = "https://localhost:44384/api/competition/comptList";

const initialState = {
    comptList: [],
    currentCompetiton: "League",
    action: "none"
};

export default class Home extends Component {

    state = {...initialState}

    constructor(props) {
        super(props)

        this.getCompetitions = this.getCompetitions.bind(this);
        this.rComptOptions = this.rComptOptions.bind(this);
        this.rComptOptionsSelectorOpts = this.rComptOptionsSelectorOpts.bind(this);
        this.handleChange = this.handleChange.bind(this);
        this.rCompetitionInfo = this.rCompetitionInfo.bind(this);
        this.defineAction = this.defineAction.bind(this);
    }

    componentWillMount () {
        this.getCompetitions();
    }

    handleChange (event) {
        this.setState({currentCompetiton: event.target.value})
    }

    defineAction (action) {
        this.setState({action: action})
    }

    getCompetitions () {

        axios["get"](apiComptLstURL)
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
        <select name="competitions" id="competitions" value={this.state.currentCompetiton} onChange={e => this.handleChange(e)}>
            {this.rComptOptionsSelectorOpts()}
        </select>
        )
    }

    rCompetitionInfo () {
        switch (this.state.currentCompetiton) {
            
            case "League":
                return (
                    <div>
                        <League action={this.state.action}/>
                    </div>
                )
            
            case "Cup":
                return (
                    <div>
                        <Cup action={this.state.action}/>
                    </div>
                )
            
            default:
                    return (
                        <div>
                            Esta competição ainda está a ser preparada, caros senhores.
                        </div>
                    )
        }
    }


    render () {
        return (
            <div className="homee">
                    {this.rComptOptions()}
                    <button className="oldBtn" onClick={e => this.defineAction("cal")}>Calendar</button>
                    <button className="oldBtn" onClick={e => this.defineAction("ngame")}>Next Game</button>
                    <button className="oldBtn" onClick={e => this.defineAction("class")}>Classification</button>
                    {this.rCompetitionInfo()}
            </div>
        )
    }
}