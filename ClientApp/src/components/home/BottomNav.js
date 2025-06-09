import React from 'react';
import './Home.css';

export function BottomNav() {
    return (
        <footer className='bottomNav'>
            <address>
                <strong>Customer Service Office</strong><br />
                +48 333 333 333<br />
                <a href="mailto:skyblue33.customerservice@gmail.com">skyblue33.customerservice@gmail.com</a>
            </address>
            <address>
                <strong>Main Office Address</strong><br />
                Elsnera 8/63<br />
                58-506 Jelenia Góra
            </address>
        </footer>
    );
}