import { create } from "zustand";
import { devtools, persist } from "zustand/middleware";
import { getAccessToken, getRefreshToken } from "../api/handlerJWT";
import { claim } from "../models/auth.model";

interface authenticationStoreProps {
  status: "idle" | "signOut" | "signIn";
  accessToken: string | null;
  refreshToken: string | null;
  credentials: claim[];
  errors: string[];
  setCredencials: (credentials: claim[]) => void;
  signIn: (token: string, refreshToken: string) => void;
  signOut: () => void;
  hydrate: () => void;
}

export const authenticationStore = create<authenticationStoreProps>()(
  devtools(
    persist(
      (set, get) => ({
        status: "idle",
        accessToken: null,
        refreshToken: null,
        credentials: [],
        errors: [],
        setCredencials: (credentials: claim[]) =>
          set({ credentials: credentials }),
        signIn: (token, refreshT) => {
          set({
            status: "signIn",
            accessToken: token,
            refreshToken: refreshT,
          });
        },
        signOut: () => {
          set({
            status: "signOut",
            accessToken: null,
            refreshToken: null,
          });
        },
        hydrate: () => {
          const token = getAccessToken();
          const refreshToken = getRefreshToken();
          if (token !== null && refreshToken !== null) {
            get().signIn(token, refreshToken);
          } else {
            get().signOut();
          }
        },
      }),
      {
        name: "auth-storage",
      }
    )
  )
);

export const hydrateAuth = () => authenticationStore.getState().hydrate();
