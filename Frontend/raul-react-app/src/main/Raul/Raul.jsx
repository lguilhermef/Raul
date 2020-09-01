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
            universe: props.universe,
            age: age,
            season: season,
            competition: competition,
            bannerWord: bannerWord,
        }
        
        this.setBanner = this.setBanner.bind(this);
    }

    setBanner (bannerWord) {
        if (this.state.bannerWord != bannerWord) {
            this.setState({bannerWord: bannerWord})
        }
    }

    render () {

        return (
            <div className="raul">
                <Header user={this.state.user} universe={this.state.universe}/>
                <Banner bannerWord={this.state.bannerWord}/>
                <RaulRoutes setBanner={this.setBanner} user={this.state.user} universe={this.state.universe}/>
            </div>
        )
    }
}
