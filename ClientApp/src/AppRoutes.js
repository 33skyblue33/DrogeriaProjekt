import { Home } from "./components/home/Home";
import { Register } from './components/Register';
import { Login } from './components/Login';
import { Cart } from './components/Cart';


const AppRoutes = [
    {
        path: '/',
        index: true,
        element: <Home />
    },
    {
        path: '/Register',
        element: <Register />
    },
    {
        path: '/Login',
        element: <Login />
    },
    {
        path: '/Cart',
        element: <Cart />

    },
];

export default AppRoutes;
