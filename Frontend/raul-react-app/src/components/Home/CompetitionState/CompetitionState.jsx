import React from 'react'
import './CompetitionState.css'

const renderWinner = function (competition) {
    return competition.winnerId ? "Competition winner: " + competition.winnerId : "Currently, Luís is in the first place."
}

export default props => 
    <div className="comptState">
        {renderWinner(props.competition)}
    </div>