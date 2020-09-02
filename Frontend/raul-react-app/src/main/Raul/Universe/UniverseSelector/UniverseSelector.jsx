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

        this.rUniverseSelector = this.rUniverseSelector.bind(this);
        this.handleChange = this.handleChange.bind(this);
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

    handleChange (event) {

        let universe = this.state.universeLst.find(u => u.id == event.target.value);
        
        if (universe) {
            this.props.setUniverse(universe)
        }
    }

    rUniverseSelector () {
        
        return (
        <select name="universes" id="universes" onChange={e => this.handleChange(e)} value={this.state.universe.id}>
            <option value={0} disabled={true}>Select Universe</option>
            {this.rComptOptionsSelectorOpts()}
        </select>
        )
    }

    rComptOptionsSelectorOpts () {
        let key = 1;
        return this.state.universeLst.map((u) =>
            <option key={key++} value={u.id}>{u.alias}</option>
        )
    }

    render () {
        return (
            <div className="uselector">
                {this.rUniverseSelector()}
            </div>
        )
    }
}