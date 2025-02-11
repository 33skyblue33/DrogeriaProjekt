import React from 'react';
import { TopNav } from './home/TopNav';
import { useNavigate } from 'react-router-dom';
import './Login.css';

export function Login() {
    return (
        <div className="login">
            <TopNav></TopNav>
            <form className="form">
                <h1 className="header">Log in</h1>
                <label className="label">E-mail or phone number</label>
                <div className="inputContainer">
                    <input required className="input" type="text"></input>
                    <span className="error" title="E-mail or phone numer is required!"></span>
                </div>
                <label className="label">Password</label>
                <div className="inputContainer">
                    <input required className="input" type="password"></input>
                    <span className="error" title="Password is required!"></span>

                </div>

                <div className="inputContainer">
                    <button className="submit">Login</button>
                    <span className="error"></span>
                </div>
                <a href="/Register" className="link">Don't have an account? Click here to register.</a>
            </form>
        </div>
    )
}