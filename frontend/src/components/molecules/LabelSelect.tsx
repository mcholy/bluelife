function LabelSelect({ id, placeholder }: selectProps) {
  return (
    <div className="form-control w-full max-w-xs">
      <label className="label">
        <span className="label-text">{placeholder}</span>
      </label>
      <select id={id} className="select select-bordered">
        <option disabled>
          Pick one
        </option>
        <option>Star Wars</option>
        <option>Harry Potter</option>
        <option>Lord of the Rings</option>
        <option>Planet of the Apes</option>
        <option>Star Trek</option>
      </select>
    </div>
  );
}

interface selectProps {
  id: string;
  placeholder: string;
}

export default LabelSelect;
