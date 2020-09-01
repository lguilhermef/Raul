import React, { Component } from 'react'
import './Universe.css'
import { Link } from 'react-router-dom'

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
                T
            </div>
        )
    }
}
