import ButtonBase from "../atoms/ButtonBase";
import LabelTextInput from "../molecules/LabelTextInput";

function BarraBusquedaDNI() {
  return (
    <div className="flex items-end drawer-content content-stretch gap-x-8 gap-y-5 pt-6 pl-6	 w-full">
      <div className="pr-60">
        <LabelTextInput id="txt_Dni" placeholder="Numero de DNI" />
      </div>
      <div>
        <ButtonBase id="btn_BuscarDni" placeholder="Buscar DNI" />
      </div>
    </div>
  );
}

export default BarraBusquedaDNI;
