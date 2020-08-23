import React from 'react'

const leagueAscii = "\n" +
" ██████╗ █████╗ ███╗   ███╗██████╗ ███████╗ ██████╗ ███╗   ██╗ █████╗ ████████╗ ██████╗ \n" +
"██╔════╝██╔══██╗████╗ ████║██╔══██╗██╔════╝██╔═══██╗████╗  ██║██╔══██╗╚══██╔══╝██╔═══██╗\n" +
"██║     ███████║██╔████╔██║██████╔╝█████╗  ██║   ██║██╔██╗ ██║███████║   ██║   ██║   ██║\n" +
"██║     ██╔══██║██║╚██╔╝██║██╔═══╝ ██╔══╝  ██║   ██║██║╚██╗██║██╔══██║   ██║   ██║   ██║\n" +
"╚██████╗██║  ██║██║ ╚═╝ ██║██║     ███████╗╚██████╔╝██║ ╚████║██║  ██║   ██║   ╚██████╔╝\n" +
" ╚═════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝     ╚══════╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ \n" +
"                                                                                        \n";

const cupAscii = "\n" +        
"████████╗ █████╗  ██████╗ █████╗ \n" +
"╚══██╔══╝██╔══██╗██╔════╝██╔══██╗\n" +
"   ██║   ███████║██║     ███████║\n" +
"   ██║   ██╔══██║██║     ██╔══██║\n" +
"   ██║   ██║  ██║╚██████╗██║  ██║\n" +
"   ╚═╝   ╚═╝  ╚═╝ ╚═██══╝╚═╝  ╚═╝\n" +
"                                 \n";

function asciiRender (competition) {
    return (
        <div>
            {competition}
        </div>
    )
}


function getAscii (competition) {

    switch (competition) {

        case "League":
            return asciiRender(leagueAscii);

        case "Cup":
            return asciiRender(cupAscii);
    }
}

function renderer (competition) {

    let bannerAscii = getAscii(competition)

    return (
        <div>
            {bannerAscii}
        </div>
    )
}

export default props =>
    <pre>
        {renderer(props.currCompetition)}
    </pre>