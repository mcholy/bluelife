import { create } from "zustand";
import validarLogin from "../api/validadLogin";

interface InfoValidacionStore {
  data: unknown;
  loading: boolean;
  setInfoValidacion: (usuario: string, contrasenia: string) => void;
}

export const infoValidacionStore = create<InfoValidacionStore>((set) => ({
  data: {},
  loading: false,
  setInfoValidacion: async (usuario, contrasenia) => {
    try {
      set({ loading: true });
      const response = await validarLogin({ usuario, contrasenia });
      set({ data: response });

      console.log({ response });
    } catch (error) {
      console.error("Error Login", error);
    } finally {
      set({ loading: false });
    }
  },
}));
