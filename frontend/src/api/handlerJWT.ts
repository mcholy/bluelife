import moment from "moment";
import { authenticationResponse, claim } from "../models/auth.model";
const tokenKey = "accessToken";
const refreshTokenKey = "refreshToken";

export const saveTokenInLocalStorage = (
  authentication: authenticationResponse
) => {
  localStorage.setItem(tokenKey, authentication.accessToken);
  localStorage.setItem(refreshTokenKey, authentication.refreshToken);
};

export const getClaims = (): claim[] => {
  const token = localStorage.getItem(tokenKey);
  if (!token) {
    return [];
  }
  const dataToken = JSON.parse(window.atob(token.split(".")[1]));
  const response: claim[] = [];
  for (const propiedad in dataToken) {
    response.push({ type: propiedad, value: dataToken[propiedad] });
  }
  const expiration = Number(response.find((x) => x.type == "exp")?.value);
  const expirationDate = moment.unix(expiration).toDate();
  if (expirationDate <= new Date()) {
    logout();
    return [];
  }
  return response;
};

export const logout = () => {
  localStorage.removeItem(tokenKey);
  localStorage.removeItem(refreshTokenKey);
};

export const getAccessToken = () => {
  return localStorage.getItem(tokenKey);
};
export const getRefreshToken = () => {
  return localStorage.getItem(refreshTokenKey);
};
