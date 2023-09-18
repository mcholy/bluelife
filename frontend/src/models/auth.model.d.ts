export interface claim {
  type: string;
  value: string;
}

export interface userCredentials {
  userName: string;
  password: string;
}

export interface authenticationResponse {
  accessToken: string;
  refreshToken: string;
}

export interface userDTO {
  id: string;
  userName: string;
}

export interface tokensDTO {
  accessToken: string;
  refreshToken: string;
}

export interface claimsResponse {
  claims: claims[];
  expired: boolean;
}
