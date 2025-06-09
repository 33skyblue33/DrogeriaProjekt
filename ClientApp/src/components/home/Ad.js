import React, { useState, useEffect } from 'react';
import { getOffers } from './api/OfferService';
import './Home.css';

export function Ad() {
    const [offers, setOffers] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);
    const [currentOffer, setCurrentOffer] = useState(0);

    useEffect(() => {
        async function fetchOffers() {
            try {
                const data = await getOffers();
                setOffers(data);
            }
            catch (err) {
                setError(err);
            }
            finally {
                setLoading(false);
            }
        }

        function displayOffer() {
            setCurrentOffer(prev => prev === 2 ? 0 : prev + 1);
        }

        fetchOffers();
        const interval = setInterval(displayOffer, 5000);

        return () => {
            clearInterval(interval);
            setOffers([]);
            setError(null);
            setLoading(true);
        };

    }, []);

    if (loading) {
        return (
            <section className='ad'>
                <p>Loading...</p>
            </section>
        );
    }

    if (error) {
        return (
            <section className='ad'>
                <p>Error: {error.message}</p>
            </section>
        );
    }

    return (
        <section className='ad'>
            <figure>
                <img src={offers[currentOffer].imagePath} alt="Advertisement" />
            </figure>
        </section>
    );
}