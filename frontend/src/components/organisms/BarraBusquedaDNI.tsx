import { useState } from "react";
import ButtonBusqueda from "../atoms/ButtonBusqueda";

function BarraBusquedaDNI() {
  const [valor, setValor] = useState("");

  return (
    <div className="flex items-end drawer-content content-stretch gap-x-8 gap-y-5 pt-6 pl-6	 w-full">
      <div className="pr-60">
        <div className="form-control w-full max-w-xs">
          <label className="label">
            <span className="label-text">Numero de DNI</span>
          </label>
          <input
            id="txt_Dni"
            type="text"
            placeholder="Numero de DNI"
            className="input input-bordered w-full max-w-xs"
            value={valor}
            onChange={(event) => {
              setValor(event.target.value);
            }}
          />
        </div>
      </div>
      <div>
        <ButtonBusqueda
          id="btn_BuscarDni"
          placeholder="Buscar DNI"
          dni={valor}
        />
      </div>
    </div>
  );
}

export default BarraBusquedaDNI;
