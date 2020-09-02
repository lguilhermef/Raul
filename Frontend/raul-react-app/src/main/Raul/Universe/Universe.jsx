import React, { Component } from 'react'
import './Universe.css'
import { Link } from 'react-router-dom'
import UniverseSelector from './UniverseSelector/UniverseSelector';

const bannerWord = "Universe";

export default class Universe extends Component {

    constructor(props) {
        super(props)
        
    }

    componentDidMount () {
        this.props.setBanner(bannerWord);
    }

    render () {
        return (
            <div>
                <UniverseSelector universe={this.props.universe} user={this.props.user}/>
            </div>
        )
    }
}
