import { RouteObject, createBrowserRouter } from "react-router-dom";
import AuthRedirect from "../components/atoms/AuthRedirect";
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
    element: <AuthRedirect />,
  },
  {
    path: "/login",
    element: <AuthRedirect><LoginPage /></AuthRedirect>,
  },
  {
    path: "/home",
    element: <AuthRedirect><HomePage /></AuthRedirect>,
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
  {
    path: '*',
    element: <AuthRedirect />,
    errorElement: <ErrorPage />,
  },
];

export const router = createBrowserRouter(routes);
