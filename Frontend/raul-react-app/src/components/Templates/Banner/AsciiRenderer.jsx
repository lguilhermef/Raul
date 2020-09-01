import React from 'react'
import AsciiBannerBank from './AsciiBannerBank';

function bannerRenderer (word) {

    const asciBanner = new AsciiBannerBank().getAsciiBanner(word);

    return (
        <pre>
            {asciBanner}
        </pre>
    )
}

export default props =>
    <div>
        {bannerRenderer(props.bannerWord)}
    </div>