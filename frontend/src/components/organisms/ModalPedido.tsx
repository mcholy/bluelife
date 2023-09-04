import LabelSelect from "../molecules/LabelSelect";
import LabelTextInput from "../molecules/LabelTextInput";

function ModalPedido() {
  return (
    <div>
      <button
        className="btn"
        onClick={() =>
          (
            document.getElementById("modalCliente") as HTMLFormElement
          ).showModal()
        }
      >
        Agregar Cliente
      </button>
      <dialog id="modalCliente" className="modal">
        <form method="dialog" className="modal-box">
          <button className="btn btn-sm btn-circle btn-ghost absolute right-2 top-2">
            ✕
          </button>
          <div className="navbar text-primary-content">
            <a className="normal-case text-xl">Registro de nuevo Cliente</a>
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelSelect id="Sel_Cliente" placeholder="Cliente" />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelSelect id="Sel_Repartidor" placeholder="Repartidor" />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput
              id="Txt_FechaEntrega"
              placeholder="Fecha de entrega"
            />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput id="Txt_Comentario" placeholder="Comentario" />
          </div>
        </form>
      </dialog>
    </div>
  );
}
export default ModalPedido;
