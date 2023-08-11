function LabelTextArea({ id, placeholder }: textareaProps) {
  return (
    <div className="form-control">
      <label className="label">
        <span className="label-text">{placeholder}</span>
      </label>
      <textarea
        id={id}
        className="textarea textarea-bordered textarea-md w-full max-w-xs"
        placeholder="Bio"
      ></textarea>
    </div>
  );
}
interface textareaProps {
  id: string;
  placeholder: string;
}
export default LabelTextArea;
