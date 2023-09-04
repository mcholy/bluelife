import LabelSelect from "../molecules/LabelSelect";
import LabelTextInput from "../molecules/LabelTextInput";
function ModalMovimiento() {
  return (
    <div className="float-left	 ">
      <button
        className="btn btn-info btn-sm mr-4"
        onClick={() =>
          (
            document.getElementById("modalmovimiento") as HTMLFormElement
          ).showModal()
        }
      >
        Movimiento
      </button>
      <dialog id="modalmovimiento" className="modal">
        <form method="dialog" className="modal-box">
          <button className="btn btn-sm btn-circle btn-ghost absolute right-2 top-2">
            ✕
          </button>
          <div className="navbar text-primary-content">
            <a className="normal-case text-xl">Movimiento</a>
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput id="Txt_Cantidad" placeholder="Cantidad" />
            <LabelSelect
              id="Sel_TipoMovimiento"
              placeholder="Tipo Movimiento"
            />
          </div>

          <div className="modal-action">
            <button className="btn">Cerrar</button>
          </div>
        </form>
      </dialog>
    </div>
  );
}

export default ModalMovimiento;
