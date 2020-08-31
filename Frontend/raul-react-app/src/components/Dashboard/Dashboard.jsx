import React from 'react'
import { Component } from 'react'
import './Dashboard.css'

import Header from './Header/Header'
import Banner from './Banner/Banner'
import Routes from './Routes'

const competition = {
    universeId: null,
    comptName: "League",
    alias: "",
    history: "",
    rules: "",
    winnerId: null,
    edition: null,
    isOfficialCompetition: null
}

export default class Dashboard extends Component {

    constructor (props) {
        super(props);

        this.state = {
            competition: competition,//"Leage"
            universe: props.universe,
            comptList: [],
        }

        this.setCompetitionName = this.setCompetitionName.bind(this);
    }

    setCompetitionName (competitionName) {
        //I need to get a compt from the API

        let test = competition;
        test.comptName = competitionName

        this.setState({competition: test});
    }

    render () {
        return (
            <div>
                <Header universe={this.state.universe} className="header" setCompetitionName={this.setCompetitionName} user={this.props.user}/>
                <Banner currCompetition={this.state.competition}/>
                <Routes currCompetition={this.state.competition} user={this.props.user} universe={this.props.universe}/>
            </div>
        )
    }
} 
