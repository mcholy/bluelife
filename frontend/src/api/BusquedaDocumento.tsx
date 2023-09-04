import axios from "axios";
import { infoPersonaStore } from "../stores/infoPersonaStore";

const setInfoPersona = infoPersonaStore((state) => state.setInfoPersona);

function busquedaDocumentoPost({ dni, force }: busquedaProps) {
  const uid = "21326";
  axios
    .post(
      `http://www.infoburo.com.pe/android/BuscarDocumento?uid=${uid}&dni=${dni}&force=${force}`
    )
    .then((res) => {
      console.log(res.data.data);
      setInfoPersona(res.data.data);
    });
}
interface busquedaProps {
  dni: string;
  force: string;
}
export default busquedaDocumentoPost;
