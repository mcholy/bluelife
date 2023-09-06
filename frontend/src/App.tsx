import { RouterProvider } from "react-router-dom";
import { router } from "./routes/router";

//configureInterceptor();

function App() {
  return (
    <RouterProvider router={router} />
  );
}

export default App;
