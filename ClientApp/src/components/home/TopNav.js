import React from 'react'; 
import { SearchBox } from './SearchBox';
import { LogCart } from './LogCart';
import { useNavigate } from 'react-router-dom';
import './Home.css';


export function TopNav()
{
    const navigate = useNavigate();

    return(
        <nav className="topNav">
            <section className="logoSearchBox">
                <div id="logo" onClick={()=>navigate('/') }>SKYBLUE</div>
                <SearchBox></SearchBox>
            </section>
            <LogCart></LogCart>
        </nav>
    );
}

export default TopNav;