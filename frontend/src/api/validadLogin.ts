async function validarLogin({ usuario, contrasenia }: validacionLoginProps) {
  const validacion2 = true;
  const concat = usuario + contrasenia;

  return validacion2 + concat;
}

interface validacionLoginProps {
  usuario: string;
  contrasenia: string;
}
export default validarLogin;
