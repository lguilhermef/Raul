import React from 'react'
import { Component } from 'react'
import './NextGame.css'
import Card from '../../components/Templates/Card/Card'

import axios from 'axios'

const apiNextGameUrl = "https://localhost:44384/api/game/nextGame"

export default class NextGame extends Component {

    constructor (props) {
        super(props)
        
        this.state = {
            universe: this.props.universe,
            competition: this.props.currCompetition,
            nextGame: null
        }
        
        this.test = this.test.bind(this);
    }

    componentDidMount() {

        axios({
            method: 'post',
            url: apiNextGameUrl,
            data: {
                universeId: this.state.universe.id,
                competitionName: this.state.competition.comptName,
                competitionEdition: this.state.competition.edition
            }
          }).then(resp => {
              this.setState({nextGame: resp.data})
          })
    }

    test () {
        return (
                <div className="card">
                    Home Team: <span className="team"> {this.state.nextGame?.homeTeam} </span>
                    <input className="inputField"></input>
                    Away Team: <span className="team">{this.state.nextGame?.awayTeam} </span>
                    <input className="inputField"></input>
                    
                    <button className="oldBtn">
                        Save Game
                    </button>
                </div>
        )
    }

    render () {
        return (
            [
            <Card renderContent={this.test}/>,
            <Card renderContent={this.test}></Card>,

            <Card renderContent={this.test}></Card>,

            <Card renderContent={this.test}></Card>,


            <Card renderContent={this.test}></Card>]

        )
    }
}