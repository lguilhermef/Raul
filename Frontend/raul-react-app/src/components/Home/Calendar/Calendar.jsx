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
            competitionName: props.currCompetition.comptName,
            gameList: []
        }

        this.renderGames = this.renderGames.bind(this);
        this.getWinner = this.getWinner.bind(this);
    }

    componentDidMount () {

        axios({
            method: "post",
            url: apiCalendar,
            data: {
                universeId: this.state.universe.id,
                competitionName: this.state.competitionName
            }
          }).then(resp => {
              this.setState({gameList: resp.data})
        })
    }

    renderGames () {
        return this.state.gameList.map(g =>
            <li title={this.getWinner(g)} className={g.isOver ? "playedGame" : "game"}>Game {g.competitionRound} 
            - {g.potName}: <strong>{g.homeTeam}</strong> {g.homeScore} x {g.awayScore} <strong>{g.awayTeam}</strong></li>
        )
    }

    getWinner (game) { 
        if (!game.isOver) {
            return null;
        }

        if (game.homeScore == game.awayScore) {
            return "Draw"
        }

        return game.homeScore > game.awayScore ? "Winner: " + game.homeRaulUUsername : "Winner: " + game.awayRaulUUsername;
    }

    render () {
        return (
            <div className="container">
                <div className="calendar">
                    {this.renderGames()}
                </div>
                <button>Play New {this.state.competitionName}</button>
            </div>
        )
    }
}