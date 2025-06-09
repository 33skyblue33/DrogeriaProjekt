import React from 'react'; 
import { useNavigate } from 'react-router-dom';
import './PanelAccount.css';
import { TopNav } from './home/TopNav';

export function PanelAccount() {
    return (
       
        <main className="panelAccount">
            <TopNav></TopNav>
            <form className="accountContainer">My Account
                <label className="changeLabel">Phone number</label>
                <input type="text" className="changeInput"></input>
                <label className="changeLabel">Old password</label>
                <input type="password" className="changeInput"></input>
                <label className="changeLabel">New password</label>
                <input type="password" className="changeInput"></input>
                <label className="changeLabel">Confirm new password</label>
                <input type="password" className="changeInput"></input>
                <section className="accountButtons">
                    <button className="accountButton cancel">Cancel changes</button>
                    <button className="accountButton confirm">Confirm changes</button>
                    <button className="accountButton delete">Delete account</button>
                </section>
            </form>
        </main>
    )
}
