import axios from 'axios';

export async function getOffers() {
    try {
        const response = await axios.get(`http://skyblue33.runasp.net/Offer`);
        return response.data;
    }
    catch (error) {
        throw error;
    }
}