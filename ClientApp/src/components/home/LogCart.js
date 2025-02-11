import React from 'react';
import { useNavigate } from 'react-router-dom';
import './Home.css';

export function LogCart() {
    const navigate = useNavigate();
    return (
        <div className='logCart' >
            <i onClick={()=>navigate('/Login')}  className='fa fa-fw fa-user-circle'></i>
            <i className='fa fa-fw fa-shopping-cart' onClick={()=>navigate('/Cart')}></i>
        </div>
    );
}