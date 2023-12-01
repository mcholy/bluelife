import {
  authenticationResponse,
  tokenDTO,
  userCredentials,
} from "../models/auth.model";
import axiosWithHeaders from "../utils/axiosWithHeaders";
import { urlAuth, urlToken } from "../utils/endpoints";

export async function login(credencials: userCredentials) {
  try {
    const response = await axiosWithHeaders.post<authenticationResponse>(
      `${urlAuth}/login`,
      credencials
    );
    return response.data;
  } catch (error) {
    console.error("Error:", error);
  }
}

export async function refreshToken(tokens: tokenDTO) {
  try {
    const response = await axiosWithHeaders.post<authenticationResponse>(
      `${urlToken}/refresh`,
      tokens
    );
    return response.data;
  } catch (error) {
    console.error("Error:", error);
  }
}
