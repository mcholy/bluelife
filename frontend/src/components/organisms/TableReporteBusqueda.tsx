/* eslint-disable react-hooks/exhaustive-deps */
import { useEffect, useState } from "react";
import { infoListBuscquedaStore } from "../../stores/listBusquedasStore";

function TableReporteBusqueda() {
  const infoListBusquedaData = infoListBuscquedaStore((state) => state.data);
  const loading = infoListBuscquedaStore((state) => state.loading);
  const { getInfoListBuscqueda } = infoListBuscquedaStore();
  const [datosListBusqueda, setDatosListBuscqueda] = useState<
    listarBusquedaProps[]
  >([]);

  useEffect(() => {
    async function fetchData() {
      try {
        await getInfoListBuscqueda();
      } catch (error) {
        console.error(error);
      }
    }
    fetchData();
  }, []);

  useEffect(() => {
    if (
      typeof infoListBusquedaData === "object" &&
      Object.keys(infoListBusquedaData as object).length > 0
    ) {
      setDatosListBuscqueda(infoListBusquedaData as listarBusquedaProps[]);
    }
  }, [infoListBusquedaData]);

  if (loading)
    return (
      <div className="flex justify-center">
        <div className="stats shadow">
          <div className="stat justify-items-center">
            <div className="stat-title">Cargando...</div>
            <div className="stat-value flex items-center">
              <span className="loading loading-bars loading-xs"></span>
              <span className="loading loading-bars loading-sm"></span>
              <span className="loading loading-bars loading-md"></span>
              <span className="loading loading-bars loading-lg"></span>
            </div>
            <div className="stat-desc">Recopilando información</div>
          </div>
        </div>
      </div>
    );

  return (
    <div>
      <div className="text-xl font-medium">Búsqueda</div>
      <div className="card mt-2">
        <div className="overflow-x-auto">
          <table className="table">
            <thead>
              <tr>
                <th>N°</th>
                <th>DNI</th>
                <th>Apellido Paterno</th>
                <th>Apellido Materno</th>
                <th>Nombres</th>
                <th>Lugar de Nacimiento</th>
                <th>Fecha de Búsqueda</th>
              </tr>
            </thead>
            <tbody>
              {datosListBusqueda
                ? datosListBusqueda.map((list, index) => (
                    <tr key={`list-${index}`}>
                      <td>{index + 1}</td>
                      <td>{list.Dni}</td>
                      <td>{list.Paterno}</td>
                      <td>{list.Materno}</td>
                      <td>{list.Nombres}</td>
                      <td>{list.Lugar_Nacimiento}</td>
                      <td>{list.Date}</td>
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
  Dni: string;
  Paterno: string;
  Materno: string;
  Nombres: string;
  Lugar_Nacimiento: string;
  Date: string;
}

export default TableReporteBusqueda;
