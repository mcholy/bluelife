import axiosWithHeaders from "../utils/axiosWithHeaders";
import { urlPersonaInfo } from "../utils/endpoints";
async function busquedaDocumentoPost({ dni, force }: busquedaProps) {
  let personaData;
  await axiosWithHeaders
    .get(`${urlPersonaInfo}?dni=${dni}&force=${force}`)
    .then((res) => {
      res.data = JSON.parse(res.data.replace(/\\/g, ""));
      personaData = res.data.data;
    })
    .catch(function (error) {
      if (error.response) {
        // The request was made and the server responded with a status code
        // that falls out of the range of 2xx
        console.log(error.response.data);
        console.log(error.response.status);
        console.log(error.response.headers);
      } else if (error.request) {
        // The request was made but no response was received
        // error.request is an instance of XMLHttpRequest in the browser
        // and an instance of http.ClientRequest in node.js
        console.log(error.request);
      } else {
        // Something happened in setting up the request that triggered an Error
        console.log("Error", error.message);
      }
    });

  return personaData;
}
interface busquedaProps {
  dni: string;
  force: string;
}
export default busquedaDocumentoPost;
