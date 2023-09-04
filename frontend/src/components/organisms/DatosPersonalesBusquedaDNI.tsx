import { create } from "zustand";
interface contadores {
  count: number;
  usuario: string;
  increase: () => void;
  changeUserName: (name: string) => void;
}
const useStoreBear = create<contadores>((set) => ({
  count: 0,
  usuario: "Navarro",
  increase: () => set((prev) => ({ ...prev, count: prev.count + 1 })),
  changeUserName: (name: string) => set((prev) => ({ ...prev, usuario: name })),
}));

const Counter = () => {
  const count = useStoreBear((state) => state.count);
  const increase = useStoreBear((state) => state.increase);
  const changeName = useStoreBear((state) => state.changeUserName);
  const usuario = useStoreBear((state) => state.usuario);
  return (
    <div className="counter">
      <span>Counter:{count}</span>
      <button onClick={() => increase()} className="btn btn-active btn-neutral">
        one up
      </button>
      <br />
      <span>Nombre actualizado:{usuario}</span>
      <br />
      <button
        onClick={() => changeName("Carlos")}
        className="btn btn-active btn-neutral"
      >
        one up
      </button>
    </div>
  );
};

export default function Contadorosos() {
  return (
    <>
      <div className="main">
        <div className="code">
          <div className="code-container">
            <Counter />
          </div>
        </div>
      </div>
    </>
  );
}
