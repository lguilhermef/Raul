import React from 'react'
import AsciiBannerBank from './AsciiBannerBank';

function renderer (competition) {

    const asciBannerBank = new AsciiBannerBank().getAsciiBanner(competition);

    return (
        <pre>
            {asciBannerBank}
        </pre>
    )
}

export default props =>
    <div>
        {renderer(props.currCompetition)}
    </div>