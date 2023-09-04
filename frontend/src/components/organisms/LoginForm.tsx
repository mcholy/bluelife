import { useState } from "react";
import ButtonLogin from "../atoms/ButtonLogin";

function LoginForm() {
  const [usuario, setUsuario] = useState("");
  const [contrasenia, setContrasenia] = useState("");
  return (
    <div className="hero h-full bg-base-100">
      <div className="hero-content flex-col lg:flex-row-reverse">
        <div className="card flex-shrink-0 w-full max-w-sm shadow-2xl bg-base-100">
          <div className="card-body">
            <div className="form-control">
              <label className="label">
                <span className="label-text">Email</span>
              </label>
              <input
                type="text"
                placeholder="email"
                className="input input-bordered"
                value={usuario}
                onChange={(event) => {
                  setUsuario(event.target.value);
                }}
              />
            </div>
            <div className="form-control">
              <label className="label">
                <span className="label-text">Password</span>
              </label>
              <input
                type="text"
                placeholder="password"
                className="input input-bordered"
                value={contrasenia}
                onChange={(event) => {
                  setContrasenia(event.target.value);
                }}
              />
              <label className="label">
                <a href="#" className="label-text-alt link link-hover">
                  Forgot password?
                </a>
              </label>
            </div>

            <div className="form-control mt-6">
              <ButtonLogin
                id="btn_Login"
                placeholder="Iniciar Sesión"
                usuario={usuario}
                contrasenia={contrasenia}
              />
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default LoginForm;
