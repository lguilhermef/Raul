import React from 'react'
import './Competition.css'
import Card from '../../../components/Templates/Card/Card'
import { Component } from 'react'
import axios from 'axios'

//This should come from an Enum that configs all API endpoints
const goalsPerPlayerURL = "https://localhost:44384/api/statistics/comptGoalsPerPlayer";
const competitionPlayerStatisticsURL = "https://localhost:44384/api/statistics/competitionPlayerStatistics";

export default class Statistics extends Component {

    constructor(props) {
        super(props)

        this.state = {
            user: props.user,
            universe: props.universe,
            competition: props.currCompetition,
            lstUserGoals: {},
            lstUserWins: {},
        }

        this.rUserGoalsScored = this.rUserGoalsScored.bind(this);
        this.rUserWins = this.rUserWins.bind(this);
        this.fetchGoalsPerPlayer = this.fetchGoalsPerPlayer.bind(this);
        this.fetchCompetitionStatistics = this.fetchCompetitionStatistics.bind(this);
        this.tst = this.tst.bind(this);
    }

    componentDidMount() {
        
        this.fetchGoalsPerPlayer();
        this.fetchCompetitionStatistics();
    }

    fetchGoalsPerPlayer () {

        axios({
            method: "post",
            url: goalsPerPlayerURL,
            data: {
                universeId: this.state.universe.id,
                competitionName: this.state.competition.comptName,
                competitionEdition: this.state.competition.edition
            }
        })
            .then(resp => {
                this.setState({lstUserGoals: resp.data});
        })
    }

    fetchCompetitionStatistics() {
        
        axios({
            method: "post",
            url: competitionPlayerStatisticsURL,
            data: {
                universeId: this.state.universe.id,
                competitionName: this.state.competition.comptName,
                competitionEdition: this.state.competition.edition
            }
        })
            .then(resp => {
                this.setState({lstUserWins: resp.data});
        })
    }


    //<p className="game">Com esta situação, Ant foi campeão 58% das vezes</p>
    tst () {
        return (
            <div className="card">
                <p className="game">Jogos por jogar:</p>    
                <p className="game">Vitórias Luís:</p>
                <p className="game">Precisa de X vitórias</p>
                <p className="game">Precisa de X vitórias (para vencer ou empate e finalissima?)</p>
                <p className="game">Vitórias António:</p>
                <p className="game">Precisa de X vitórias</p>
            </div>
        )
    }

    //If (num of games left to play  < PlayerWithMostWinsWins -> We have a winner) ??
    //Num. Games Left - Num Wins of the Most Wins = num of victores the player with the most wins is missing  ??
    rUserWins() {
        let keys = Object.keys(this.state.lstUserWins);
        

        return (
            <div className="card" style={{}}>
                <h5 className="game">Game Results</h5>
                {keys.map(user => {
                    return <li className="playedGame">{user} won <strong>{this.state.lstUserWins[user]}</strong> games</li>
                })}
            </div>
        )
    }

    //Played game should actually be repalced by a css element
    rUserGoalsScored () {

        let keys = Object.keys(this.state.lstUserGoals);

        return (
            <div className="card" style={{}}>
                <h5 className="game">Goals Scored</h5>
                {keys.map(user => {
                    return <li className="playedGame">{user} scored <strong>{this.state.lstUserGoals[user]}</strong> goals</li>
                })}
            </div>
        )
    }

    render () {
        return (
            <div className="container" style={{display: "inline-block", maxWidth: "10%"}}>
                <Card style={{marginLeft: "50px"}} renderContent={this.rUserWins}></Card>
                <Card style={{marginLeft: "50px"}} renderContent={this.rUserGoalsScored}></Card>
            </div>
        )
    }
}