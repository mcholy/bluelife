import axios from "axios";
async function busquedaDocumentoPost({ dni, force }: busquedaProps) {
  const uid = "0";
  let personaData;
  await axios
    .post(
      `http://www.infoburo.com.pe/android/BuscarDocumentoAndroid?uid=${uid}&dni=${dni}&force=${force}`
    )
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
