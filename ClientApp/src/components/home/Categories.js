import React, { useState, useEffect } from 'react';
import { getCategories } from './api/CategoryService';
import './Home.css'

export function Categories()
{
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
    },[]);

    if (loading)
    {
        return (
            <div className='categories'>
            <div className='category'>Loading...</div>
            </div>
        );
    }

    if (error)
    {
        return (
            <div className='categories'>
                <div className='category'>Error: {error.message}</div>
            </div>
        );
    }

    return (
        <div className='categories'>
            {categories.map((category) => (
                <div className='category' key={category.categoryId}>{category.name}</div>
            )) }
        </div>

    );
}