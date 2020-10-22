import React from 'react'
import './Season.css'
import { Link } from 'react-router-dom'
import { Component } from 'react'
import Carrousel from '../../../components/Templates/Carrousel/Carrousel'

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
                <Carrousel content={"Season"} 
                leftArrowLink={"/age"} leftArrowTitle={"Age"}
                rightArrowLink={"competition"} rightArrowTitle={"Competition"}/>
            </div>
        )
    }
}