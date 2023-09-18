import moment from "moment";
import {
  authenticationResponse,
  claim,
  claimsResponse,
} from "../models/auth.model";
const tokenKey = "accessToken";
const refreshTokenKey = "refreshToken";

export const saveTokenInLocalStorage = (
  authentication: authenticationResponse
) => {
  localStorage.setItem(tokenKey, authentication.accessToken);
  localStorage.setItem(refreshTokenKey, authentication.refreshToken);
};

export const getClaims = (): claimsResponse => {
  const token = getAccessToken();
  const response: claimsResponse = {
    claims: [],
    expired: false,
  };
  if (!token) {
    return response;
  }
  response.claims = decodeToken(token);
  response.expired = verifyExpiration(response.claims);
  return response;
};

export const logout = () => {
  localStorage.removeItem(tokenKey);
  localStorage.removeItem(refreshTokenKey);
  localStorage.clear();
};

export const getAccessToken = () => {
  return localStorage.getItem(tokenKey);
};

export const getRefreshToken = () => {
  return localStorage.getItem(refreshTokenKey);
};

export const verifyExpiration = (claims: claim[]) => {
  const expiration = Number(claims.find((x) => x.type == "exp")?.value);
  const expirationDate = moment.unix(expiration).toDate();
  return expirationDate <= new Date();
};

export const decodeToken = (token: string) => {
  const decodedToken = JSON.parse(window.atob(token.split(".")[1]));
  const response: claim[] = [];
  for (const propiedad in decodedToken) {
    response.push({ type: propiedad, value: decodedToken[propiedad] });
  }
  return response;
};
