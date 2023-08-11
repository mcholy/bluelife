function TablePedido() {
  return (
    <div className="overflow-x-auto">
      <table className="table-lg">
        {/* head */}
        <thead>
          <tr>
            <th></th>
            <th>Cliente</th>
            <th>Repartidor</th>
            <th>Fecha Reparto</th>
            <th>Celular</th>
            <th>Direccion </th>
            <th></th>
          </tr>  
        </thead>
        <tbody>
          {/* row 1 */}
          <tr className="hover">
            <th>1</th>
            <td>Cy Ganderton</td>
            <td>Cy Ganderton</td>
            <td>Quality Control Specialist</td>
            <td>Blue</td>
            <td>7</td>
            <td>
              <button className="btn btn-success btn-xs mr-4">Editar</button>
              <button className="btn btn-error btn-xs">Eliminar</button>
            </td>
          </tr>
          {/* row 2 */}
          <tr className="hover">
            <th>2</th>
            <td>Hart Hagerty</td>
            <td>Hart Hagerty</td>
            <td>Desktop Support Technician</td>
            <td>Purple</td>
            <td>7</td>
            <td>
              <button className="btn btn-success btn-xs mr-4">Editar</button>
              <button className="btn btn-error btn-xs">Eliminar</button>
            </td>
          </tr>
          {/* row 3 */}
          <tr className="hover">
            <th>3</th>
            <td>Brice Swyre</td>
            <td>Hart Hagerty</td>
            <td>Tax Accountant</td>
            <td>Red</td>
            <td>7</td>
            <td>
              <button className="btn btn-success btn-xs mr-4">Editar</button>
              <button className="btn btn-error btn-xs">Eliminar</button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  );
}
export default TablePedido;
