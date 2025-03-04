import React from 'react';
import { useNavigate } from 'react-router-dom';
import './Home.css';

export function LogCart() {
    const navigate = useNavigate();
    function login() {
        var loggedIn = sessionStorage.getItem("loggedIn");
        if (loggedIn) {
            navigate("/MyAccount");
        }
        else {
            navigate("/Login");
        }
    }

    return (
        <div className='logCart' >
            <i onClick={login}  className='fa fa-fw fa-user-circle'></i>
            <i className='fa fa-fw fa-shopping-cart' onClick={()=>navigate('/Cart')}></i>
        </div>
    );
}