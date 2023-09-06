function ButtonLogin({ placeholder, disabled, type }: loginProps) {
  return (
    <button
      type={type}
      className="btn btn-active btn-neutral"
      disabled={disabled}
    >
      {placeholder}
    </button>
  );
}
interface loginProps {
  placeholder: string;
  disabled: boolean;
  type: "submit" | "button";
}

ButtonLogin.DefaultProps = {
  type: "button",
}
export default ButtonLogin;
