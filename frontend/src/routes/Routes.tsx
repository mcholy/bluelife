import {
  Navigate,
  RouterProvider,
  createBrowserRouter,
} from "react-router-dom";
import PrivateRoute from "../components/atoms/PrivateRoute";
import Almacen from "../layouts/Almacen";
import BusquedaDNI from "../layouts/BusquedaDNI";
import Cliente from "../layouts/Cliente";
import User from "../layouts/User";
import ErrorPage from "../pages/ErrorPage";
import LoginPage from "../pages/LoginPage";
import { authenticationStore } from "../stores/authenticationStore";

const Routes = () => {
  const { accessToken } = authenticationStore();
  const routesForAuthenticatedOnly = [
    {
      path: "/login",
      element: <LoginPage />,
    },
    {
      path: "/",
      element: <PrivateRoute />,
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
          path: "busquedadni",
          element: <BusquedaDNI />,
        },
      ],
      errorElement: <Navigate to="/" />,
    },
  ];

  const routesForNotAuthenticatedOnly = [
    {
      path: "/",
      element: <Navigate to="/login" />,
      errorElement: <ErrorPage />,
    },
    {
      path: "/login",
      element: <LoginPage />,
    },
  ];

  const router = createBrowserRouter([
    ...(!accessToken ? routesForNotAuthenticatedOnly : []),
    ...routesForAuthenticatedOnly,
  ]);

  return <RouterProvider router={router} />;
};
export default Routes;
