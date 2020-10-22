import React from 'react'
import { Component } from 'react'
import './Competition.css'
import { Link } from 'react-router-dom'
import Carrousel from '../../../components/Templates/Carrousel/Carrousel'
import Calendar from '../../../components/Home/Calendar/Calendar'

const competitione = {
    universeId: 1,
    comptName: "League",
    alias: "",
    history: "",
    rules: "",
    winnerId: null,
    edition: null,
    isOfficialCompetition: null
}

const pressedBtn = "";

export default class Competition extends Component {

    constructor(props) {
        super(props)
        console.log("CONSTRRUTOOORE " + props.pressedBtn)
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
        
        console.log("hjehe" + this.state.pressedBtn);
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
          <div>
              PRÓXIMO JOGO - CRIAR COMPONENTE
          </div>  
        );
    }

    rCalendar() {
        return (
            <Calendar className="tst" universe={this.state.universe} currCompetition={this.state.competition}/>
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