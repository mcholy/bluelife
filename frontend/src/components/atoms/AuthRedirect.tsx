import { Navigate, useLocation } from "react-router-dom";
import useAuth from "../../hooks/useAuth";

interface AuthRedirectProps {
    children?: React.ReactNode;
}
export default function AuthRedirect({ children }: AuthRedirectProps) {
    const location = useLocation();
    const isAuthenticated = useAuth();
    if (!isAuthenticated && location.pathname !== "/login") {
        return <Navigate to="/login" />;
    }
    if (isAuthenticated && location.pathname === "/login") {
        return <Navigate to="/home" />;
    }
    console.log(location.pathname);
    return <>{children}</>;
}