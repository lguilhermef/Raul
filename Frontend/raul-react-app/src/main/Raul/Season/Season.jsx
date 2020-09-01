import React from 'react'
import './Season.css'
import { Link } from 'react-router-dom'
import { Component } from 'react'

const bannerWord = "Season";

export default class Season extends Component {

    constructor (props) {
        super(props)
    }

    componentDidMount () {
        this.props.setBanner(bannerWord);
    }

    render () {

        return (
            <div>
                Season
                <Link to="/age">
                    <button className="oldBtn">age</button>
                </Link>
                <Link to="/competition">
                    <button className="oldBtn">competition</button>
                </Link>
            </div>
        )
    }
}