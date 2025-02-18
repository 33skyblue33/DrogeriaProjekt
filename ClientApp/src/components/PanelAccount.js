import React from 'react'; 
import { useNavigate } from 'react-router-dom';
import './PanelAccount.css';
import { TopNav } from './home/TopNav';

export function PanelAccount() {
    return (
       
        <div className="panelAccount">
            <TopNav></TopNav>
            <form className="accountContainer">My Account
                <div className="changeLabel">Phone number</div>
                <input type="text" className="changeInput"></input>
                <div className="changeLabel">Old password</div>
                <input type="password" className="changeInput"></input>
                <div className="changeLabel">New password</div>
                <input type="password" className="changeInput"></input>
                <div className="changeLabel">Confirm new password</div>
                <input type="password" className="changeInput"></input>
                <div className="accountButtons">
                    <button className="accountButton cancel">Cancel changes</button>
                    <button className="accountButton confirm">Confirm changes</button>
                    <button className="accountButton delete">Delete account</button>
                </div>
            </form>
        </div>
    )
}
