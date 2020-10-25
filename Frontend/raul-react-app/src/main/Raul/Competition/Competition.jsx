import React from 'react'
import { Component } from 'react'
import './Competition.css'
import { Link } from 'react-router-dom'
import Carrousel from '../../../components/Templates/Carrousel/Carrousel'
import Calendar from '../../../components/Calendar/Calendar'
import NextGame from '../../../components/NextGame/NextGame'

const pressedBtn = "";

export default class Competition extends Component {

    constructor(props) {
        super(props)

        this.state = {
            user: props.user,
            universe: props.universe,
            competition: props.currCompetition,
            pressedBtn: props.pressedBtn
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

    rCalendar() {
        return (
            <Calendar universe={this.state.universe} currCompetition={this.state.competition}/>
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