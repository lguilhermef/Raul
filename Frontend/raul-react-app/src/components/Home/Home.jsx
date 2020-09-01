import React from 'react'
import { Component } from 'react'
import './Home.css'

import axios from 'axios'

import Header from './Header/Header'
import Banner from './Banner/Banner'
import Routes from './Routes'
import CompetitionState from './CompetitionState/CompetitionState'

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

export default class Home extends Component {

    constructor (props) {
        super(props);

        this.state = {
            competition: competition,
            universe: props.universe,
            comptList: [],
        }

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

    render () {
        return (
            <div className="dashboard">
                <Header universe={this.state.universe} className="header" setCompetition={this.setCompetition} user={this.props.user}/>
                <Banner currCompetition={this.state.competition}/>
                <CompetitionState competition={this.state.competition}/>
                <Routes currCompetition={this.state.competition} user={this.props.user} universe={this.props.universe}/>
            </div>
        )
    }
} 
