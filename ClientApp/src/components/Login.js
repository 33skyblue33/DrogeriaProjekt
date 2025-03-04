import { React, useState } from 'react';
import { TopNav } from './home/TopNav';
import { useNavigate } from 'react-router-dom';
import './Login.css';
import axios from 'axios';

export function Login() {
    const [credential, setCredential] = useState('');
    const [password, setPassword] = useState('');

    async function login(event) {
        event.preventDefault();

        if (credential === "" || password === "") {
            return;
        }

        try {
            const response = await axios.post('http://localhost:5204/User/Login', {
                credential: credential,
                password: password
            });

            var result = response.data;

            if (result) {
                alert("zalogowano");
            }
            else {
                alert("nie ma takiego użytkownika");
            }
        }
        catch (error) {
            throw error;
        }
    }

    return (
        <div className="login">
            <TopNav></TopNav>
            <form className="form">
                <h1 className="header">Log in</h1>
                <label className="label">E-mail or phone number</label>
                <div className="inputContainer">
                    <input value={credential} onChange={(e) => setCredential(e.target.value)} required className="input" type="text"></input>
                    <span className="error" title="E-mail or phone numer is required!"></span>
                </div>
                <label className="label">Password</label>
                <div className="inputContainer">
                    <input value={password} onChange={(e) => setPassword(e.target.value)} required className="input" type="password"></input>
                    <span className="error" title="Password is required!"></span>

                </div>

                <div className="inputContainer">
                    <button className="submit" onClick={(event) => login(event) }>Login</button>
                    <span className="error"></span>
                </div>
                <a href="/Register" className="link">Don't have an account? Click here to register.</a>
            </form>
        </div>
    )
}