import { Navigate, useLocation } from "react-router-dom";
import { authenticationStore } from "../../stores/authenticationStore";

interface AuthProviderProps {
  children?: React.ReactNode;
}
export default function AuthProvider({ children }: AuthProviderProps) {
  const location = useLocation();
  const { status } = authenticationStore();
  if (
    status === "signOut" ||
    (status === "idle" && location.pathname !== "/login")
  ) {
    return <Navigate to="/login" />;
  }
  if (status === "signIn" && location.pathname === "/login") {
    return <Navigate to="/home" />;
  }
  console.log(`no condition, status: ${status} `, location.pathname);
  return <>{children}</>;
}
