import React, { Component } from 'react'
import './Universe.css'
import { Link } from 'react-router-dom'
import UniverseSelector from './UniverseSelector/UniverseSelector';

const bannerWord = "Universe";

export default class Universe extends Component {

    constructor(props) {
        super(props)

        this.state = {
            universe: props.universe,
            showForm: false,
            newUniverseBtnTitle: "New Universe"
        }

        this.updateFormStatus = this.updateFormStatus.bind(this);
    }

    componentDidMount () {
        this.props.setBanner(bannerWord);
    }

    rEnterBtn () {

        let btnTitle = this.state.universe.id == 0 ? "Select a Universe first." : "Enter " + this.state.universe.alias + ".";
        let btnClass = this.state.universe.id == 0 ? "btnInactive" : "oldBtn";

        return (
            <Link to={"/season"}>
                <button className={btnClass} disabled={this.state.universe.id == 0} title={btnTitle}>Enter</button>
            </Link>
        )
    }

    rRegisterBtnAndForm () {

        if (!this.state.showForm) {
            return
        }

        return (
            [
                <input type="text" className="input" placeholder="Insert Alias..."></input>,
                <textarea rows="5" type="text" className="input" placeholder="Universe description..."></textarea>
            ]
        )
    }

    updateFormStatus () {
        this.setState({showForm: !this.state.showForm});
    }

    render () {
        return (
            <div className="universe">
                <UniverseSelector setUniverse={this.props.setUniverse} user={this.props.user} universe={this.props.universe}/>
                {this.rEnterBtn()}
                <hr className="hr"></hr>
                {this.rRegisterBtnAndForm()}
                <button className="btnRegister oldBtn" 
                    onClick={() => this.updateFormStatus()}>{this.state.newUniverseBtnTitle}</button>
            </div>
        )
    }
}
