import axios from "axios";
import { urlPersonaInfo } from "../utils/endpoints";
async function busquedaDocumentoPost({ dni, force }: busquedaProps) {
  const uid = "0";
  let personaData;
  await axios
    .post(`${urlPersonaInfo}?uid=${uid}&dni=${dni}&force=${force}`)
    .then((res) => {
      personaData = res.data.data;
    });

  return personaData;
}
interface busquedaProps {
  dni: string;
  force: string;
}
export default busquedaDocumentoPost;
