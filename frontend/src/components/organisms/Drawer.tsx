function Drawer({ children }: drawerProps) {
  return (
    <div className="drawer flex-1 lg:drawer-open">
      <input id="my-drawer-2" type="checkbox" className="drawer-toggle" />
      <div className="drawer-content flex flex-col items-center ">
        {children}

        <label
          htmlFor="my-drawer-2"
          className="btn btn-primary drawer-button lg:hidden"
        >
          BluLife
        </label>
      </div>
      <div className="drawer-side h-full ">
        <label htmlFor="my-drawer-2" className="drawer-overlay"></label>
        <ul className="menu p-4 w-80 h-full bg-base-200 text-base-content">
          <li>
            <a>Almacen</a>
          </li>
          <li>
            <a>Clientes</a>
          </li>
          <li>
            <a>Reparto</a>
          </li>
          <li>
            <a>Post-Venta</a>
          </li>
        </ul>
      </div>
    </div>
  );
}
interface drawerProps {
  children: React.ReactNode;
}
export default Drawer;
