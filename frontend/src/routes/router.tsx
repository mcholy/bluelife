import { RouteObject, createBrowserRouter } from "react-router-dom";
import App from "../App";
import ErrorPage from "../pages/ErrorPage";

const routes: RouteObject[] = [
    {
        path: "/",
        element: <App />,
        errorElement: <ErrorPage />,
    },
    {
        path: "/login",
        element: <App />,
    },
];

export const router = createBrowserRouter(routes);