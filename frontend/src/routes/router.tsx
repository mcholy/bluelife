import { Outlet, RouteObject, createBrowserRouter } from "react-router-dom";
import Almacen from "../layouts/Almacen";
import BusquedaDNI from "../layouts/BusquedaDNI";
import Cliente from "../layouts/Cliente";
import User from "../layouts/User";
import ErrorPage from "../pages/ErrorPage";
import HomePage from "../pages/HomePage";
import LoginPage from "../pages/LoginPage";

const routes: RouteObject[] = [
  {
    path: "/",
    element: <Outlet />,
    children: [
      {
        path: "login",
        element: <LoginPage />,
      },
      {
        path: "home",
        element: <HomePage />,
        errorElement: <ErrorPage />,
        children: [
          {
            path: "cliente",
            element: <Cliente />,
          },
          {
            path: "almacen",
            element: <Almacen />,
          },
          {
            path: "usuario",
            element: <User />,
          },
          {
            path: "busquedaDNI",
            element: <BusquedaDNI />,
          },
        ],
      },
    ],
  },
];

export const router = createBrowserRouter(routes);
