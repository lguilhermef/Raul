import React, { Component } from 'react'
import './Age.css'
import { Link } from 'react-router-dom'
import Carrousel from '../../../components/Templates/Carrousel/Carrousel'


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
                <Carrousel content={"Age"} 
                leftArrowLink={"/competition"} leftArrowTitle={"Competition"}
                rightArrowLink={"/season"} rightArrowTitle={"Season"}/>
            </div>
        )
    }
}
