import React, { useState, useEffect } from 'react';
import { getCategories } from './api/CategoryService';
import './Home.css';

export function Categories() {
    const [categories, setCategories] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        async function fetchCategories() {
            try {
                const data = await getCategories();
                setCategories(data);
            }
            catch (err) {
                setError(err);
            }
            finally {
                setLoading(false);
            }
        }

        fetchCategories();

        return () => {
            setCategories([]);
            setError(null);
            setLoading(true);
        };
    }, []);

    if (loading) {
        return (
            <section className='categories'>
                <p className='category'>Loading...</p>
            </section>
        );
    }

    if (error) {
        return (
            <section className='categories'>
                <p className='category'>Error: {error.message}</p>
            </section>
        );
    }

    return (
        <section className='categories'>
            <ul>
                {categories.map((category) => (
                    <li className='category' key={category.categoryId}>{category.name}</li>
                ))}
            </ul>
        </section>
    );
}