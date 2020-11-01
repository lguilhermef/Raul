import React from 'react'
import './Competition.css'
import Card from '../../../components/Templates/Card/Card'
import { Component } from 'react'
import axios from 'axios'

//This should come from an Enum that configs all API endpoints
const goalsPerPlayerURL = "https://localhost:44384/api/statistics/comptGoalsPerPlayer"

export default class Statistics extends Component {

    constructor(props) {
        super(props)

        this.state = {
            user: props.user,
            universe: props.universe,
            competition: props.currCompetition,
            lstUserGoals: {}
        }

        this.tst = this.tst.bind(this);
    }

    componentDidMount() {
        
        axios({
            method: "post",
            url: goalsPerPlayerURL,
            data: {
                universeId: this.state.universe.id,
                competitionName: this.state.competition.comptName,
                competitionEdition: this.state.competition.edition
            }
          }).then(resp => {
              this.setState({lstUserGoals: resp.data})
              console.log("SAPPAAA")
              console.log(this.state.lstUserGoals["Luís"])
              //It's here :)
        })
    }

    //Played game should actually be repalced by a css element
    tst () {

        let keys = ["Luís", "António"];

        return (
            <div className="card" style={{}}>
                {keys.map(user => {
                    return <li className="playedGame">{user} scored: {this.state.lstUserGoals[user]}</li>
                })}
            </div>
        )
    }

    render () {
        return (
            <Card style={{marginLeft: "50px"}} renderContent={this.tst}></Card>
        )
    }
}