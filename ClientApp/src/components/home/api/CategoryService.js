import axios from 'axios';

export async function getCategories() {
    try {
        const response = await axios.get('http://localhost:5204/Category');
        return response.data;
    }
    catch (error) {
        throw error;
    }
}