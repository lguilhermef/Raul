import React from 'react'
import './Calendar.css'
import { Component } from 'react'
import axios from 'axios'

const apiCalendar = "https://localhost:44384/api/competition/calendar";


export default class Calendar extends Component {

    constructor(props) {
        super(props)

        this.state = {
            user: props.user,
            universe: props.universe,
            competitionName: props.currCompetition,
            gameList: []
        }

        this.renderGames = this.renderGames.bind(this);
    }

    componentDidMount () {

        axios({
            method: "post",
            url: apiCalendar,
            data: {
                universeId: this.state.universe, //number
                competitionName: this.state.competitionName //string
            }
          }).then(resp => {
              this.setState({gameList: resp.data})
          })
    }

    renderGames () {
        return this.state.gameList.map(g =>
        <li>Game {g.competitionRound} - {g.potName}: <strong>{g.homeTeam}</strong> {g.homeScore} x {g.awayScore} <strong>{g.awayTeam}</strong></li>
        )
    }

    render () {
        return (
            <div className="calendar">
                <p>User: {this.state.user.username} - Universe: {this.state.universe}</p>
                {this.renderGames()}
            </div>
        )
    }
}