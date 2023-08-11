import axios from "axios";
import { useEffect } from "react";
import HomePage from "./pages/HomePage";
function App() {
  useEffect(() => {
    axios
      .get("https://localhost:7103/api/personas")
      .then((res) => console.log(res.data));

    axios
      .post(
        "http://www.infoburo.com.pe/android/BuscarDocumento?uid=21326&dni=61622589&force=1"
      )
      .then((res) => console.log(res.data));
  }, []);

  return <HomePage />;
}

export default App;
