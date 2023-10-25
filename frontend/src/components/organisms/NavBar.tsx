import { useNavigate } from "react-router-dom";
import { logout } from "../../api/handlerJWT";
import { authenticationStore } from "../../stores/authenticationStore";

function NavBar({ title }: navBarProps) {
  const {hydrate} = authenticationStore();
  const navigate = useNavigate();
  const handleLogout = () => {
    logout();
    hydrate();
    navigate("/login", { replace: true });
  };
  return (
    <div className="navbar bg-neutral">
      <div className="flex-1">
        <a className="btn btn-ghost normal-case text-xl">{title}</a>
      </div>
      <div className="flex-none gap-2">
        <div className="form-control">
          <input
            type="text"
            placeholder="Buscar"
            className="input input-bordered w-24 md:w-auto"
          />
        </div>
        <div className="dropdown dropdown-end">
          <label tabIndex={0} className="btn btn-ghost btn-circle avatar">
            <div className="w-10 rounded-full">
              <img alt="photo" src="src/assets/images/photo-example.jpg" />
            </div>
          </label>
          <ul
            tabIndex={0}
            className="mt-3 z-[1] p-2 shadow menu menu-sm dropdown-content bg-base-300 rounded-box w-52"
          >
            {/*<li>
              <a className="justify-between">
                Perfil
                <span className="badge">New</span>
              </a>
            </li>
            <li>
              <a>Configuración</a>
            </li>*/}
            <li>
              <button onClick={handleLogout}>Cerrar Sesión</button>
            </li>
          </ul>
        </div>
      </div>
    </div>
  );
}
interface navBarProps {
  title: string;
}
export default NavBar;
