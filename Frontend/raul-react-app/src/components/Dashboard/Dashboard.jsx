import React from 'react'
import { Component } from 'react'
import './Dashboard.css'

import Header from './Header/Header'
import Banner from './Banner/Banner'
import Routes from './Routes'


export default class Dashboard extends Component {

    constructor (props) {
        super(props);

        this.state = {
            competition: "League",
            comptList: [],
        }

        this.setCompetition = this.setCompetition.bind(this);
    }

    setCompetition (competition) {
        this.setState({competition: competition});
    }

    render () {
        return (
            <div>
                <Header className="header" setCompetition={this.setCompetition} user={this.props.user}/>
                <Banner currCompetition={this.state.competition}/>
                <Routes currCompetition={this.state.competition}/>
            </div>
        )
    }
} 
