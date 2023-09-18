import { useEffect } from "react";
import { refreshToken } from "../api/authentication";
import {
  getAccessToken,
  getClaims,
  getRefreshToken,
  logout,
  saveTokenInLocalStorage,
} from "../api/handlerJWT";
import { authenticationResponse } from "../models/auth.model";
import { authenticationStore } from "../stores/authenticationStore";

export async function checkAndTryRefreshToken() {
  try {
    const { expired } = getClaims();
    if (expired) {
      const response = await refreshToken({
        accessToken: getAccessToken()!,
        refreshToken: getRefreshToken()!,
      });
      saveTokenInLocalStorage(response as authenticationResponse);
    } else {
      saveTokenInLocalStorage({
        accessToken: getAccessToken()!,
        refreshToken: getRefreshToken()!,
      });
    }
  } catch (error) {
    logout();
  }
}

function useAuth() {
  const { hydrate } = authenticationStore();
  useEffect(() => {
    hydrate();
    return () => {};
  }, [hydrate]);
}

export default useAuth;
