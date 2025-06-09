import React from "react";
import { TopNav } from './home/TopNav';
import { Categories } from './home/Categories';
import { useNavigate } from 'react-router-dom';
import './Cart.css';

export function Cart() {
    return (
        <main className="cart">
            <TopNav></TopNav>
            <Categories></Categories>
            <section className="summaryCart">
                <div className="boxCart">
                    <section className="cartTitle">Cart(3)</section>
                    <section className="list"></section>
                </div>
                <section className="checkout">Checkout</section>
            </section>
        </main>
        
    );
}