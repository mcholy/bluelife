import { useEffect } from "react";
import { getAccessToken } from "../api/handlerJWT";
import { authenticationStore } from "../stores/authenticationStore";

interface AuthState {
  isLoggedIn: boolean;
}

function checkAuthentication(): AuthState {
  const token = getAccessToken();
  const isLoggedIn = !!token;
  return { isLoggedIn };
}

function useAuth() {
  const { isAuthenticated, setIsAuthenticated } = authenticationStore();
  useEffect(() => {
    const { isLoggedIn } = checkAuthentication();
    setIsAuthenticated(isLoggedIn);
    return () => {};
  }, [setIsAuthenticated]);
  return isAuthenticated;
}

export default useAuth;
