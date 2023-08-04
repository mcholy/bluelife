function TextInputPass({ id, placeholder }: textPassProps) {
  return (
    <div className="form-control w-full max-w-xs">
      <label className="label">
        <span className="label-text">{placeholder}</span>
      </label>
      <input
        id={id}
        type="Password"
        placeholder={placeholder}
        className="input input-bordered w-full max-w-xs"
      />
    </div>
  );
}

interface textPassProps {
  id: string;
  placeholder: string;
}

export default TextInputPass;
