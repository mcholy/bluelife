import ModalUser from "../components/organisms/ModalUsers";
import TableUser from "../components/organisms/TableUser";
export default function User() {
  return (
    <div className="flex flex-col content-stretch gap-x-8 gap-y-5 pt-6 pl-6	 w-full">
      <ModalUser />
      <TableUser />
    </div>
  );
}
