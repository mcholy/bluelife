import { useNavigate } from "react-router-dom";
import { infoValidacionStore } from "../../stores/validarLoginStore";
function ButtonLogin({ id, placeholder, usuario, contrasenia }: loginProps) {
  const navigate = useNavigate();
  const { setInfoValidacion } = infoValidacionStore();
  const validaLogin = (usuario: string, contrasenia: string) => {
    setInfoValidacion(usuario, contrasenia);
    navigate("/home/");
  };

  return (
    <button
      id={id}
      className="btn btn-active btn-neutral"
      onClick={() => validaLogin(usuario, contrasenia)}
    >
      {placeholder}
    </button>
  );
}
interface loginProps {
  id: string;
  placeholder: string;
  usuario: string;
  contrasenia: string;
}
export default ButtonLogin;
