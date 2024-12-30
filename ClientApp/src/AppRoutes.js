import { Home } from "./components/home/Home";
import { Register } from './components/Register';


const AppRoutes = [
    {
      path:'/', 
    index: true,
    element: <Home />
    },
    {
        path: '/Register',
        element: <Register />
    }
];

export default AppRoutes;
