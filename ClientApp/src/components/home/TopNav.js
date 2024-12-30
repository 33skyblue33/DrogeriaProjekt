import React from 'react'; 
import { SearchBox } from './SearchBox';
import { LogCart } from './LogCart';
import { useNavigate } from 'react-router-dom';
import './Home.css';


export function TopNav()
{
    const navigate = useNavigate();

    return(
        <div className="topNav">
            <div className="logoSearchBox">
                <div id="logo" onClick={()=>navigate('/') }>SKYBLUE</div>
                <SearchBox></SearchBox>
            </div>
            <LogCart></LogCart>
        </div>
    );
}

export default TopNav;