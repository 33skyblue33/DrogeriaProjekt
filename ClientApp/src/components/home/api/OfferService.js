import axios from 'axios';

export async function getOffers() {
    try {
        const response = await axios.get('http://localhost:5204/Offer');
        return response.data;
    }
    catch (error) {
        throw error;
    }
}