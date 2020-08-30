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

    }

    render () {
        return (
            <div className="calendar">
                <p>User: {this.state.user.username} - Universe: {this.state.universe}</p>
                <li>Jornada 02 - Pote A:  <strong>Manchester City</strong> 1 x 2 <strong> Juventus </strong></li>
            </div>
        )
    }
}