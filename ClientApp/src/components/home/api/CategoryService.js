import axios from 'axios';

export async function getCategories() {
    try {
        const response = await axios.get('http://skyblue33.runasp.net/Category');
        return response.data;
    }
    catch (error) {
        throw error;
    }
}