import axios from "axios";
import { useEffect } from "react";
import LoginPage from "./pages/LoginPage";
function App() {

  useEffect(
    () => {
      axios.get("https://localhost:7103/api/personas").then(res => console.log(res.data));
    }, []);

  return (
    <LoginPage />
  )
}

export default App
