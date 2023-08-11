import axios from "axios";
function createPost() {
  axios
    .post(
      "http://www.infoburo.com.pe/android/BuscarDocumento?uid=21326&dni=61622589&force=1"
    )
    .then((res) => console.log(res.data));
}
function ButtonBase({ id, placeholder }: buttonProps) {
  return (
    <button id={id} className="btn btn-active btn-neutral" onClick={createPost}>
      <svg
        xmlns="http://www.w3.org/2000/svg"
        className="h-6 w-6"
        fill="none"
        viewBox="0 0 24 24"
        stroke="currentColor"
      >
        <path
          strokeLinecap="round"
          strokeLinejoin="round"
          strokeWidth="2"
          d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"
        />
      </svg>
      {placeholder}
    </button>
  );
}

interface buttonProps {
  id: string;
  placeholder: string;
}

export default ButtonBase;
