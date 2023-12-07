import { create } from "zustand";
import listarBusquedasGet from "../api/ListarBusquedas";
import { checkAndTryRefreshToken } from "../hooks/useAuth";

interface InfoListBusquedaStore {
  data: unknown;
  loading: boolean;
  getInfoListBuscqueda: (userexterno: string) => void;
}

export const infoListBusquedaStore = create<InfoListBusquedaStore>((set) => ({
  data: {},
  loading: false,
  getInfoListBuscqueda: async (userexterno) => {
    try {
      set({ loading: true });
      await checkAndTryRefreshToken();
      const response = await listarBusquedasGet(userexterno);
      //const { claims } = getClaims();
      set({ data: response });
    } catch (error) {
      console.error("Error data", error);
    } finally {
      set({ loading: false });
    }
  },
}));
