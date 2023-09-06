import axios from "axios";
import { authenticationResponse, userCredentials } from "../models/auth.model";
import { urlAuth } from "../utils/endpoints";

export async function login(credencials: userCredentials) {
  try {
    const headers = {
      "Content-Type": "application/json",
      Accept: "application/json",
      // Authorization: 'Bearer yourAccessToken', // Add an authorization header if required
    };
    const response = await axios.post<authenticationResponse>(
      `${urlAuth}/login`,
      credencials,
      { headers }
    );
    return response.data;
  } catch (error) {
    console.error("Error:", error);
  }
}
