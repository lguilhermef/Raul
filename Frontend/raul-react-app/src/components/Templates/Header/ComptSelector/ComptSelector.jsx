import React from 'react'
import './ComptSelector.css'
import axios from 'axios'
import { Component } from 'react'

const apiComptLstURL = "https://localhost:44384/api/competition/comptList";

export default class ComptSelector extends Component {

    constructor (props) {
        super(props);

        this.state = {
            competition: "League",
            universe: props.universe,
            comptList: []
        }

        this.rComptOptions = this.rComptOptions.bind(this);
    }

    componentDidMount () {

        axios({
            method: 'post',
            url: apiComptLstURL,
            data: {
                id: this.state.universe.id,
            }
          }).then(resp => {
              this.setState({comptList: resp.data})
          })
    }

    handleChange (event) {
        this.props.setCompetition(event.target.value)
    }

    rComptOptions () {
        
        return (
        <select name="competitions" id="competitions" value={this.state.currentCompetiton} onChange={e => this.handleChange(e)}>
            {this.rComptOptionsSelectorOpts()}
        </select>
        )
    }

    rComptOptionsSelectorOpts () {
        let key = 1;
        return this.state.comptList.map((c) =>
            <option key={key++} value={c.comptName} selected={c.comptName == "League"}>{c.comptName}</option>
        )
    }

    render () {
        return (
            <div className="cselector">
                {this.rComptOptions()}
            </div>
        )
    }
}
