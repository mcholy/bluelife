import ModalCliente from "../components/organisms/ModalCliente";
import TableCliente from "../components/organisms/TableCliente";
export default function Cliente() {
  return (
    <div className="flex flex-col content-stretch gap-x-8 gap-y-5 pt-6 pl-6	 w-full">
      <ModalCliente />

      <TableCliente />
    </div>
  );
}
