import React, { Component } from 'react'
import './Age.css'
import { Link } from 'react-router-dom'

const bannerWord = "Age";

export default class Age extends Component {

    constructor(props) {
        super(props)
        
    }

    componentDidMount () {
        this.props.setBanner(bannerWord);
    }

    render () {
        return (
            <div>
                Age
                <Link to="/universe">
                    <button className="oldBtn">universe</button>
                </Link>
                <Link to="/season">
                    <button className="oldBtn">season</button>
                </Link>
            </div>
        )
    }
}
