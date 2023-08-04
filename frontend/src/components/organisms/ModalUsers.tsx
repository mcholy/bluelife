import LabelSelect from "../molecules/LabelSelect";
import LabelTexPassword from "../molecules/LabelTexPassword";
import LabelTextInput from "../molecules/LabelTextInput";
function ModalUser() {
  return (
    <div>
      <button
        className="btn"
        onClick={() =>
          (document.getElementById("my_modal_5") as HTMLFormElement).showModal()
        }
      >
        Agregar Usuario
      </button>
      <dialog id="my_modal_5" className="modal">
        <form method="dialog" className="modal-box">
          <button className="btn btn-sm btn-circle btn-ghost absolute right-2 top-2">
            ✕
          </button>
          <div className="navbar text-primary-content">
            <a className="normal-case text-xl">Registro de usuario</a>
          </div>
          <div className="flex flex-col justify-center items-center">
            <LabelTextInput id="Txt_Nombres" placeholder="Nombres" />
            <LabelTextInput id="Txt_ApPaterno" placeholder="Apellido paterno" />
            <LabelTextInput id="Txt_ApMaterno" placeholder="Apellido materno" />
            <LabelTextInput id="Txt_Email" placeholder="Correo electronico" />
            <LabelTexPassword id="Txt_Password" placeholder="Contraseña" />
            <LabelSelect id="Sel_TipoUsuario" placeholder="Tipo de Usuario" />
          </div>
          <div className="modal-action">
            <button className="btn">Close</button>
          </div>
        </form>
      </dialog>
    </div>
  );
}

export default ModalUser;
