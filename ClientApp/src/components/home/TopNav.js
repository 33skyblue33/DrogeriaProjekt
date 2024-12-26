import React from 'react'; 
import { SearchBox } from './SearchBox';
import { LogCart } from './LogCart';
import './Home.css';


export function TopNav()
{
    return(
        <div className="topNav">
            <div className="logoSearchBox">
                <div id="logo">SKYBLUE</div>
                <SearchBox></SearchBox>
            </div>
            <LogCart></LogCart>
        </div>
    );
}

export default TopNav;