import { RouteObject, createBrowserRouter } from "react-router-dom";
import App from "../App";
import ErrorPage from "../pages/ErrorPage";
import HomePage from "../pages/HomePage";
import Cliente from "../layouts/Cliente";
import Almacen from "../layouts/Almacen";
import User from "../layouts/User";
import BusquedaDNI from "../layouts/BusquedaDNI";

const routes: RouteObject[] = [
  {
    path: "/",
    element: <App />,
    errorElement: <ErrorPage />,
    children: [
      {
        path: "Cliente/",
        element: <Cliente />,
      },
      {
        path: "Almacen/",
        element: <Almacen />,
      },
      {
        path: "Usuario/",
        element: <User />,
      },
      {
        path: "BusquedaDNI/",
        element: <BusquedaDNI />,
      },
    ],
  },
  {
    path: "/login",
    element: <App />,
  },
  {
    path: "/home",
    element: <HomePage />,
    errorElement: <ErrorPage />,
  },
];

export const router = createBrowserRouter(routes);
