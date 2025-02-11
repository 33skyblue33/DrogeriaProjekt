import React,{ useRef } from 'react';
import { TopNav } from './home/TopNav';
import { useNavigate } from 'react-router-dom';
import './Login.css';

export function Register()
{
    const navigate = useNavigate();
    const passwordRef = useRef(null);
    const passwordErrorRef = useRef(null);
    const confirmPasswordRef = useRef(null);
    const confirmPasswordErrorRef = useRef(null);
    function validatePassword() {
        const password = passwordRef.current;
        const uppercaseRegex = /[A-Z]/;
        const lowercaseRegex = /[a-z]/;
        const numberRegex = /[0-9]/;
        const specialRegex = /[^A-Za-z0-9]/;

        if (password.value.length < 8) {
            password.setCustomValidity("Password is too short!");
        }

        if (!uppercaseRegex.test(password.value)) {
            password.setCustomValidity("Password must contain at least one uppercase letter!");
        }

        if (!lowercaseRegex.test(password.value)) {
            password.setCustomValidity("Password must contain at least one lowercase letter!");
        }

        if (!numberRegex.test(password.value)) {
            password.setCustomValidity("Password must contain at least one number!");
        }

        if (!specialRegex.test(password.value)) {
            password.setCustomValidity("Password must contain at least one special character!");
        }
        
    }

    function validateConfirmPassword() {
        const password = passwordRef.current;
        const confirmPassword = confirmPasswordRef.current;

        if (password.value !== confirmPassword.value) {
            confirmPassword.setCustomValidity("Passwords must match!");
        }
    }

    return (
        <div className='login'>
            <TopNav></TopNav>
            <form className="form">
                <h1 className="header">Create account</h1>
                <label className="label">E-mail</label>
                <div className="inputContainer">
                    <input required className="input" type="email"></input>
                    <span className="error" title="E-mail must be valid!"></span>
                </div>
                <label className="label">Phone number</label>
                <div className="inputContainer">
                    <input required className="input" type="tel"></input>
                    <span className="error" title="Phone number must be valid!"></span>
                </div>
                <label className="label">Password</label>
                <div className="inputContainer">
                    <input required className="input" type="password" ref={passwordRef} onChange={validatePassword}></input>
                    <span ref={passwordErrorRef} className="error" title="Password must contain at least 8 characters, 1 uppercase letter, 1 lowercase letter, 1 number, 1 special character!"></span>
                </div>
                <label className="label">Confirm password</label>
                <div className="inputContainer">
                    <input required className="input" type="password" ref={confirmPasswordRef} onChange={validateConfirmPassword}></input>
                    <span ref={confirmPasswordErrorRef} className="error" title="Passwords must match!"></span>
                </div>
                <div className="inputContainer">
                    <button className="submit">Register</button>
                    <span className="error"></span>
                </div>
            </form>
        </div>
        
    );
}