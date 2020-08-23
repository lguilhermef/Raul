import React, { Component } from 'react'
import './Cup.css'

export default class Cup extends Component {

    constructor (props) {
        super (props);
        this.action = props.action;

        this.rCalendar = this.rCalendar.bind(this);

        this.ascii =       "\n" +        
        "████████╗ █████╗  ██████╗ █████╗ \n" +
        "╚══██╔══╝██╔══██╗██╔════╝██╔══██╗\n" +
        "   ██║   ███████║██║     ███████║\n" +
        "   ██║   ██╔══██║██║     ██╔══██║\n" +
        "   ██║   ██║  ██║╚██████╗██║  ██║\n" +
        "   ╚═╝   ╚═╝  ╚═╝ ╚═██══╝╚═╝  ╚═╝\n" +
        "                                 \n";
    }

    rCalendar() {

    }

    render () {
        return (

            <div className="aa">
                <pre className="pre">
                <hr className="hru"></hr>
                    {this.ascii}
                    <hr className="hr"></hr>
                </pre>
                {this.rCalendar()}
            </div>
        )
    }
}