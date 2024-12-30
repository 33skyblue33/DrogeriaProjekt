import React from 'react';
import { TopNav } from './home/TopNav';
import { BottomNav } from './home/BottomNav';
import { useNavigate } from 'react-router-dom';
import './Register.css';

export function Register()
{
    const navigate = useNavigate();
    
    return (
        <div className='register'>
            <TopNav></TopNav>
            <BottomNav></BottomNav>
        </div>
        
    );
}