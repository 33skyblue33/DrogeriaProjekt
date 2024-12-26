import React, { useState } from 'react';

export function Button()
{
    const [ clicks, setClicks ] = useState(0);
    function click()
    {
        setClicks(clicks + 1);
    }
    return (

        <button onClick={click }> clicks: {clicks} </button>
    );
}