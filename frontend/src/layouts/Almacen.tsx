import ModalProducto from "../components/organisms/ModalProducto";
import TableAlmacen from "../components/organisms/TableAlmacen";
export default function Almacen() {
  return (
    <div className="flex flex-col content-stretch gap-x-8 gap-y-5 pt-6 pl-6	 w-full">
      <ModalProducto />

      <TableAlmacen />
    </div>
  );
}
