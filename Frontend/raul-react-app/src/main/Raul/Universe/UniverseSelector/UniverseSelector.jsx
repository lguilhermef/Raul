import React, { Component } from 'react'
import './UniverseSelector'

import axios from 'axios'

const apiComptLstURL = "https://localhost:44384/api/universe/universeList";

export default class UniverseSelector extends Component {

    constructor (props) {
        super(props)

        this.state = {
            user: props.user,
            universe: props.universe,
            universeLst: []
        }

        this.rUniverseOpts = this.rUniverseOpts.bind(this);
    }

    componentDidMount () {

        axios({
            method: 'post',
            url: apiComptLstURL,
            data: {
                username: this.state.user.username,
            }
          }).then(resp => {
              this.setState({universeLst: resp.data})
          })
    }

    rUniverseOpts () {
        
        return (
        <select name="competitions" id="competitions" value={this.state.currentCompetiton} onChange={e => this.handleChange(e)}>
            {this.rComptOptionsSelectorOpts()}
        </select>
        )
    }

    rComptOptionsSelectorOpts () {
        let key = 1;
        return this.state.universeLst.map((g) =>
            <option key={key++} value={g.id}>{g.id}</option>
        )
    }

    render () {
        return (
            <div>
                {this.rUniverseOpts()}
            </div>
        )
    }
}