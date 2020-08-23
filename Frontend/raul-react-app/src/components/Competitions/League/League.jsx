import React, { Component } from 'react'
import './League.css'

const initialState = {
    comptList: [],
    currentCompetiton: "League",
    action: "none"
};

export default class League extends Component {

    state = {...initialState};

    constructor (props) {
        super (props);
        this.action = props.action;

        this.rCalendar = this.rCalendar.bind(this);
        this.ascii =  "\n" +
        " ██████╗ █████╗ ███╗   ███╗██████╗ ███████╗ ██████╗ ███╗   ██╗ █████╗ ████████╗ ██████╗ \n" +
        "██╔════╝██╔══██╗████╗ ████║██╔══██╗██╔════╝██╔═══██╗████╗  ██║██╔══██╗╚══██╔══╝██╔═══██╗\n" +
        "██║     ███████║██╔████╔██║██████╔╝█████╗  ██║   ██║██╔██╗ ██║███████║   ██║   ██║   ██║\n" +
        "██║     ██╔══██║██║╚██╔╝██║██╔═══╝ ██╔══╝  ██║   ██║██║╚██╗██║██╔══██║   ██║   ██║   ██║\n" +
        "╚██████╗██║  ██║██║ ╚═╝ ██║██║     ███████╗╚██████╔╝██║ ╚████║██║  ██║   ██║   ╚██████╔╝\n" +
        " ╚═════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝     ╚══════╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ \n" +
        "                                                                                        \n";

        console.log(props.action)
    }

    rCalendar () {

    }

    render () {
        return (

            <div className="aa">
                <pre className="pre">
                <hr className="hru"></hr>
                    {this.ascii}
                    <hr className="hr"></hr>
                    <button onClick={e => console.log(this.action)}>Action</button>
                </pre>
                {this.rCalendar()}
            </div>
        )
    }
} 