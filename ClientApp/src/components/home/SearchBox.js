import React from 'react';
import './Home.css';
export function SearchBox()
{
    return (
        <section className='searchBox'>
            <textarea className='search' rows='1'></textarea>
            <i className='fa fa-fw fa-search searchIcon'></i>
        </section>
    );
}