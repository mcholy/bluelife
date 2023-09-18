import { Navigate, useLocation } from "react-router-dom";
import HomePage from "../../pages/HomePage";
import { authenticationStore } from "../../stores/authenticationStore";

const PrivateRoute = () => {
  const location = useLocation();
  const { accessToken } = authenticationStore();
  return (
    <>
      {accessToken ? (
        <HomePage />
      ) : (
        <Navigate to="/login" replace={true} state={{ from: location }} />
      )}
    </>
  );
};

export default PrivateRoute;
