import { create } from "zustand";
import { createAudit } from "../api/audit";
import listarBusquedasGet from "../api/ListarBusquedas";
import { getClaims } from "../api/handlerJWT";

interface InfoListBuscquedaStore {
  data: unknown;
  loading: boolean;
  getInfoListBuscqueda: () => void;
}

export const infoListBusquedaStore = create<InfoListBuscquedaStore>((set) => ({
  data: {},
  loading: false,
  getInfoListBuscqueda: async () => {
    try {
      set({ loading: true });
      const response = await listarBusquedasGet();
      const { claims } = getClaims();
      console.log(claims);
      await createAudit({
        userName: claims.length > 0 ? claims[0]["value"] : "",
        companyName: "company",
        details: "",
      });
      set({ data: response });
    } catch (error) {
      console.error("Error data", error);
    } finally {
      set({ loading: false });
    }
  },
}));
