function TableUser() {
  return (
    <div className="overflow-x-auto">
      <table className="table-lg">
        {/* head */}
        <thead>
          <tr>
            <th></th>
            <th>Usuario</th>
            <th>Nombre y apellido</th>
            <th>Email</th>
            <th>Tipo Usuario</th>
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
            <td>Blue</td>
          </tr>
          {/* row 2 */}
          <tr className="hover">
            <th>2</th>
            <td>Hart Hagerty</td>
            <td>Hart Hagerty</td>
            <td>Desktop Support Technician</td>
            <td>Purple</td>
            <td>Blue</td>
          </tr>
          {/* row 3 */}
          <tr className="hover">
            <th>3</th>
            <td>Brice Swyre</td>
            <td>Hart Hagerty</td>
            <td>Tax Accountant</td>
            <td>Red</td>
            <td>Blue</td>
          </tr>
        </tbody>
      </table>
    </div>
  );
}
export default TableUser;
