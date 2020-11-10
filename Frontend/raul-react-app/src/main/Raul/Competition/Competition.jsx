import React from 'react'
import { Component } from 'react'
import './Competition.css'
import { Link } from 'react-router-dom'
import Carrousel from '../../../components/Templates/Carrousel/Carrousel'
import Calendar from '../../../components/Calendar/Calendar'
import NextGame from '../../../components/NextGame/NextGame'
import Statistics from './Statistics'

const pressedBtn = "";

export default class Competition extends Component {

    constructor(props) {
        super(props)

        this.state = {
            user: props.user,
            universe: props.universe,
            competition: props.currCompetition,
            pressedBtn: props.pressedBtn,
            calendarComponent: null
        }

        this.rCalendar = this.rCalendar.bind(this);
    }

    componentDidMount () {
        this.props.setBanner(this.props.currCompetition.comptName);
    }

    rContent() {
        
        //TODO: Erase if?
        if (this.state.competition?.edition == null) {
           return;
        }

        switch (this.state.pressedBtn) {
            case "calendar":
                return this.rCalendar();
                break;

            case "nextGame":
                return this.rNextGame();
                break;
            
            default:
                return this.rCalendar();
                break;
        }
    }

    rNextGame() {
        return (
            <NextGame universe={this.state.universe} currCompetition={this.state.competition}/>
        );
    }

    //Calendar should be the return of a method and saved on a variable, which would be passed to statistics.
    //Thus, statistics could make use of Calendar methods. Explore
    rCalendar() {
        return ([
            //An actual css grid would make absolute sense here, avoiding the need for all that inline style
            <Calendar universe={this.state.universe} currCompetition={this.state.competition}/>,
            <div className="container" style={{display: "inline-block", width: "5px"}}></div>,
            <Statistics universe={this.state.universe} currCompetition={this.state.competition}></Statistics>,
            <div className="container">

                <button className="oldBtn">New {this.state.competitionName}</button>
            </div>]
        );
    }

    render () {

        return (
            <div>
                <Carrousel 
                    content={this.rContent()} 
                    leftArrowLink={"/season"} leftArrowTitle={"Season"}
                    rightArrowLink={"/age"} rightArrowTitle={"Age"}/>
            </div>
        )
    }
}