import { useEffect, useState } from "react";
import { infoListBuscquedaStore } from "../../stores/listBusquedasStore";
import listarBusquedasGet from "../../api/ListarBusquedas";

function TableReporteBusqueda() {
  const infoListBusquedaData = () =>
    infoListBuscquedaStore((state) => state.data);

  infoListBuscquedaStore();
  listarBusquedasGet();
  const [datosListBusqueda, setDatosListBuscqueda] = useState<
    listarBusquedaProps[]
  >([]);
  useEffect(() => {
    if (
      typeof infoListBusquedaData === "object" &&
      "datos" in infoListBusquedaData!
    ) {
      setDatosListBuscqueda(infoListBusquedaData as listarBusquedaProps[]);
    }
  }, [infoListBusquedaData]);
  return (
    <div>
      <div className="text-xl font-medium">Busqueda</div>

      <div className="card mt-2">
        <div className="overflow-x-auto">
          <table className="table">
            {/* head */}
            <thead>
              <tr>
                <th>DNI</th>
                <th>Apellido Paterno</th>
                <th>Apellido Materno</th>
                <th>Nombres</th>
                <th>Lugar de Nacimiento</th>
                <th>Fecha de Busqueda</th>
              </tr>
            </thead>
            <tbody>
              {datosListBusqueda
                ? datosListBusqueda.map((list, index) => (
                    <tr key={`list-${index}`}>
                      <td>{list.DNI}</td>
                      <td>{list.paterno}</td>
                      <td>{list.materno}</td>
                      <td>{list.nombres}</td>
                      <td>{list.lugar_nacimiento}</td>
                      <td>{list.date}</td>
                    </tr>
                  ))
                : null}
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
}

interface listarBusquedaProps {
  DNI: string;
  paterno: string;
  materno: string;
  nombres: string;
  lugar_nacimiento: string;
  date: string;
}

export default TableReporteBusqueda;