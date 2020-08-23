import React from 'react'
import './Dashboard.css'

import Header from './Header/Header'
import Banner from './Banner/Banner'
import { Component } from 'react'

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
                <Header className="header" setCompetition={this.setCompetition}/>
                <Banner currCompetition={this.state.competition}/>
            </div>
        )
    }
} 
