import LabelTextInput from "../molecules/LabelTextInput";
function ModalProducto() {
  return (
    <div>
      <button
        className="btn"
        onClick={() =>
          (document.getElementById("modalProducto") as HTMLFormElement).showModal()
        }
      >
        Agregar Producto
      </button>
      <dialog id="modalProducto" className="modal">
        <form method="dialog" className="modal-box">
          <button className="btn btn-sm btn-circle btn-ghost absolute right-2 top-2">
            ✕
          </button>
          <div className="navbar text-primary-content">
            <a className="normal-case text-xl">Registro de nuevo Producto</a>
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput
              id="Txt_NombreProducto"
              placeholder="Nombre de Producto"
            />
          </div>
          <div className="modal-action">
            <button className="btn">Close</button>
          </div>
        </form>
      </dialog>
    </div>
  );
}

export default ModalProducto;
