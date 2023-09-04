function LabelFileInput({ id, placeholder }: fileinputProps) {
  return (
    <div className="form-control w-full max-w-xs">
      <label className="label">
        <span className="label-text">{placeholder}</span>
      </label>
      <input
        id={id}
        type="file"
        className="file-input file-input-bordered w-full max-w-xs"
        accept=".jpg, .jpeg, .png"
        multiple
      />
    </div>
  );
}
interface fileinputProps {
  id: string;
  placeholder: string;
}
export default LabelFileInput;
