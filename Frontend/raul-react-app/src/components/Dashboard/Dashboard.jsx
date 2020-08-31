import React from 'react'
import { Component } from 'react'
import './Dashboard.css'

import axios from 'axios'

import Header from './Header/Header'
import Banner from './Banner/Banner'
import Routes from './Routes'

const apiNewestCompt = "https://localhost:44384/api/competition/getNewestCompetition"

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
        this.setCompetition = this.setCompetition.bind(this);
    }

    setCompetition (competitionName) {

        axios({
            method: "post",
            url: apiNewestCompt,
            data: {
                universeId: this.state.universe.id,
                competitionName: competitionName
            }
          }).then(resp => {
              this.setState({competition: resp.data})
          })
    }

    setCompetitionName (competitionName) {
        this.setCompetition(competitionName)
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
