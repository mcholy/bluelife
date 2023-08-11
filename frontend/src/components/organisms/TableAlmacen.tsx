import ModalMovimiento from "./ModalMovimiento";
import IconTrash from "../../assets/Icons/trash-2.svg";
import IconEdit from "../../assets/Icons/edit.svg";
function TableAlmacen() {
  return (
    <div className="overflow-x-auto">
      <table className="table-lg">
        {/* head */}
        <thead>
          <tr>
            <th></th>
            <th>Producto</th>
            <th>Cantidad</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {/* row 1 */}
          <tr className="hover">
            <th>1</th>
            <td>Bidon 20 Litros (Lleno)</td>
            <td>320 </td>
            <td>
              <ModalMovimiento />
              <button className="btn btn-success btn-sm mr-4">
                <img src={IconEdit} alt="Editar" />
              </button>

              <button className="btn btn-error btn-sm">
                <img src={IconTrash} alt="Eliminar" />
              </button>
            </td>
          </tr>
          {/* row 2 */}
          <tr className="hover">
            <th>2</th>
            <td>Bolsas de Hielo 3Kg</td>
            <td>100 </td>
            <td>
              <ModalMovimiento />
              <button className="btn btn-success btn-sm mr-4">
                <img src={IconEdit} alt="Editar" />
              </button>
              <button className="btn btn-error btn-sm">
                <img src={IconTrash} alt="Eliminar" />
              </button>
            </td>
          </tr>
          {/* row 3 */}
          <tr className="hover">
            <th>3</th>
            <td>Bidon 7 Litros (Lleno)</td>
            <td>20 </td>
            <td>
              <ModalMovimiento />
              <button className="btn btn-success btn-sm mr-4">
                <img src={IconEdit} alt="Editar" />
              </button>
              <button className="btn btn-error btn-sm">
                <img src={IconTrash} alt="Eliminar" />
              </button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  );
}
export default TableAlmacen;
