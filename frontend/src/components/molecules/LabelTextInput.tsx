function TextInput({ id, placeholder }: textInputProps) {
  return (
    <div className="form-control w-full max-w-xs">
      <label className="label">
        <span className="label-text">{placeholder}</span>
      </label>
      <input
        id={id}
        type="text"
        placeholder={placeholder}
        className="input input-bordered w-full max-w-xs"
      />
    </div>
  );
}

interface textInputProps {
  id: string;
  placeholder: string;
}

export default TextInput;
