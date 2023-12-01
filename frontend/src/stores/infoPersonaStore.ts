import { create } from "zustand";
import busquedaDocumentoPost from "../api/busquedaDocumento";
import { checkAndTryRefreshToken } from "../hooks/useAuth";

interface InfoPersonaStore {
  data: unknown;
  loading: boolean;
  setInfoPersona: (dni: string, force: string) => void;
}

export const infoPersonaStore = create<InfoPersonaStore>((set) => ({
  data: {},
  loading: false,
  setInfoPersona: async (dni, force) => {
    try {
      set({ loading: true });
      await checkAndTryRefreshToken();
      const response = await busquedaDocumentoPost({ dni, force });
      //const { claims } = getClaims();
      /* await createAudit({
        userName: claims.length > 0 ? claims[0]["value"] : "",
        companyName: "company",
        details: dni,
      });*/
      set({ data: response });
    } catch (error) {
      console.error("Error data", error);
    } finally {
      set({ loading: false });
    }
  },
}));
