import React from "react";
import { TopNav } from './home/TopNav';
import { Categories } from './home/Categories';
import { useNavigate } from 'react-router-dom';
import './Cart.css';

export function Cart() {
    return (
        <div className="cart">
            <TopNav></TopNav>
            <Categories></Categories>
            <div className="summaryCart">
                <div className="boxCart">
            <div className="cartTitle">Cart(3)</div>
                <div className="list"></div>
                </div>
            <div className="checkout">Checkout</div>
            </div>
        </div>
        
    );
}