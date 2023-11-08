import { Link, Navigate, Outlet } from "react-router-dom";
import { authenticationStore } from "../../stores/authenticationStore";
function Drawer() {
  const { accessToken } = authenticationStore();
  return (
    <div className="drawer flex-1 lg:drawer-open">
      <input id="my-drawer-2" type="checkbox" className="drawer-toggle" />
      <div className="drawer-content flex flex-col">
        <>
          {accessToken ? <Outlet /> : <Navigate to="/login" replace={true} />}
        </>
        <label
          htmlFor="my-drawer-2"
          className="btn btn-primary drawer-button lg:hidden"
        >
          BlueLife
        </label>
      </div>
      <div className="drawer-side h-full ">
        <label htmlFor="my-drawer-2" className="drawer-overlay"></label>
        <ul className="menu p-4 w-80 h-full bg-base-200 text-base-content">
          {/*
          <li>
            <Link to={`/usuario`}>Usuario</Link>
          </li>
          <li>
            <Link to={`/almacen`}>Almacen</Link>
          </li>
          <li>
            <Link to={`/cliente`}>Clientes</Link>
          </li>
          */}
          <li>
            <Link to={`/busquedadni`}>Busqueda DNI</Link>
          </li>
          <li>
            <Link to={`/reportebusqueda`}>Reporte de Busquedas</Link>
          </li>
        </ul>
      </div>
    </div>
  );
}

export default Drawer;
