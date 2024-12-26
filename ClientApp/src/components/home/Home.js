import React from 'react';
import { TopNav } from './TopNav';
import { Categories } from './Categories';
import { Ad } from './Ad';
import './Home.css';
import { BottomNav } from './BottomNav';
export function Home()
{
    return (
        <div className="home">
            <TopNav></TopNav>
            <Categories></Categories>
            <Ad></Ad>
            <BottomNav></BottomNav>
        </div>
        
    );
}
