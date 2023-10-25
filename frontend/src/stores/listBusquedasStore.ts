import { create } from "zustand";
import listarBusquedasGet from "../api/ListarBusquedas";
import { getClaims } from "../api/handlerJWT";

interface InfoListBuscquedaStore {
  data: unknown;
  loading: boolean;
  getInfoListBuscqueda: () => void;
}

export const infoListBuscquedaStore = create<InfoListBuscquedaStore>((set) => ({
  data: {},
  loading: false,
  getInfoListBuscqueda: async () => {
    try {
      set({ loading: true });
      const response = await listarBusquedasGet();
      const { claims } = getClaims();
      console.log(claims);
      set({ data: response });
    } catch (error) {
      console.error("Error data", error);
    } finally {
      set({ loading: false });
    }
  },
}));
