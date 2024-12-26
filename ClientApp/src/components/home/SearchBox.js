import React from 'react';
import './Home.css';
export function SearchBox()
{
    return (
        <div className='searchBox'>
            <textarea className='search' rows='1' cols='60' maxlength='35'></textarea>
            <i className='fa fa-fw fa-search searchIcon'></i>
        </div>
    );
}