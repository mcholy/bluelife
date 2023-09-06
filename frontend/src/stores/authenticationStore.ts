import { create } from "zustand";
import { claim } from "../models/auth.model";

interface authenticationStoreProps {
  credentials: unknown;
  isAuthenticated: boolean;
  errors: string[];
  setCredencials: (credentials: claim[]) => void;
  setIsAuthenticated: (value: boolean) => void;
}

export const authenticationStore = create<authenticationStoreProps>((set) => ({
  credentials: [],
  isAuthenticated: false,
  errors: [],
  setCredencials: (credentials: claim[]) => {
    try {
      set({ credentials: credentials });
    } catch (error) {
      console.error(error);
    }
  },
  setIsAuthenticated: (value: boolean) => set({ isAuthenticated: value }),
}));
