import LabelFileInput from "../molecules/LabelFileInput";
import LabelSelect from "../molecules/LabelSelect";
import LabelTextArea from "../molecules/LabelTextArea";
import LabelTextInput from "../molecules/LabelTextInput";

function ModalCliente() {
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
            <LabelTextInput id="Txt_Nombres" placeholder="Nombres" />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput id="Txt_ApPaterno" placeholder="Apellido Paterno" />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput id="Txt_ApMaterno" placeholder="Apellido Materno" />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput
              id="Txt_Documento"
              placeholder="Documento Identidad"
            />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput id="Txt_Celular" placeholder="Celular" />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput id="Txt_Direccion" placeholder="Direccion" />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelSelect id="Sel_Producto" placeholder="Producto Recurrente" />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput id="Txt_DiasRecompra" placeholder="Dias Recompra" />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextArea id="Txt_Referencia" placeholder="Referencia" />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelFileInput
              id="Inp_imagen"
              placeholder="Imagen de referencia"
            />
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextArea id="Txt_Localizacion" placeholder="Localización" />
          </div>
        </form>
      </dialog>
    </div>
  );
}
export default ModalCliente;
