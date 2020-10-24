import React from 'react'
import { Component } from 'react'
import './NextGame.css'
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

    render () {
        return (
            <div>
                {this.state.competition.comptName}

                {this.state.nextGame?.potName}
            </div>
        )
    }
}