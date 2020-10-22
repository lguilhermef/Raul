import React from 'react'
import './Raul.css'

import RaulRoutes from './RaulRoutes'
import Header from '../../components/Templates/Header/Header'
import Banner from '../../components/Templates/Banner/Banner'
import { Component } from 'react'

const apiNewestCompt = "https://localhost:44384/api/competition/getNewestCompetition"

const universe = {
    id: 1,
    history: "",
    creationDate: null
}

const age = {
    age: 1,
    universeId: 1,
    ballonDeOrWinnerUsername: ""
}

const season = {
    seasonNumber: 1,
    age: 1,
    universeId: 1,
}

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

const bannerWord = "Season"

export default class Raul extends Component {

    constructor (props) {
        super(props)
        
        this.state = {
            user: props.user,
            universe: universe,
            age: age,
            season: season,
            competition: competition,
            bannerWord: bannerWord,
            pressedBtn: ""
        }
        
        this.setBanner = this.setBanner.bind(this);
        this.setUniverse = this.setUniverse.bind(this);
        this.setCompetition = this.setCompetition.bind(this);
        this.setPressedBtn = this.setPressedBtn.bind(this);
    }

    setBanner (bannerWord) {
        if (this.state.bannerWord != bannerWord) {
            this.setState({bannerWord: bannerWord});
        }
    }

    setUniverse (universe) {
        if (this.state.universe.id != universe.id) {
            this.setState({universe: universe});
        }
    }

    setCompetition (competition) {
        if (this.state.competition.comptName != competition.comptName) {
            this.setState({competition: competition});
        }
    }

    setPressedBtn (pressedBtn) {
        this.setState({pressedBtn: pressedBtn});
    }

    render () {

        return (
            <div className="raul">
                <Header user={this.state.user} universe={this.state.universe} setCompetition={this.setCompetition} setBanner={this.setBanner} setPressedBtn={this.setPressedBtn}/>
                <Banner bannerWord={this.state.bannerWord}/>
                <RaulRoutes setBanner={this.setBanner} setUniverse={this.setUniverse} user={this.state.user} universe={this.state.universe}
                currCompetition={this.state.competition} pressedBtn={this.state.pressedBtn}/>
            </div>
        )
    }
}
