import React, { Component } from 'react'
import './Universe.css'
import { Link } from 'react-router-dom'
import UniverseSelector from './UniverseSelector/UniverseSelector';

const bannerWord = "Universe";

export default class Universe extends Component {

    constructor(props) {
        super(props)

        this.state = {
            universe: props.universe
        }
    }

    componentDidMount () {
        this.props.setBanner(bannerWord);
    }

    render () {
        return (
            <div className="universe">
                <UniverseSelector setUniverse={this.props.setUniverse} user={this.props.user} universe={this.props.universe}/>
                <Link to="/season">
                    <button className="oldBtn"  onClick={ () => console.log(this.state.universe.alias + "LOOOOL")}>Enter</button>
                </Link>
                <button className="oldBtn"  onClick={ () => console.log(this.state.universe.id + "TEST")}>Test</button>
            </div>
        )
    }
}
