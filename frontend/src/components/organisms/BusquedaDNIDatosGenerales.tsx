import { useEffect, useState } from "react";
import { infoPersonaStore } from "../../stores/infoPersonaStore";

function SecDatosGenerales() {
  const [currentTab, setCurrentTab] = useState<string>("datosGenerales");
  const infoPersonaData = infoPersonaStore((state) => state.data);
  const loading = infoPersonaStore((state) => state.loading);
  const [datosGenerales, setDatosGenerales] = useState<datosGeneralesProps>(
    datosGeneralesDefaultValues
  );
  const [datosDirecciones, setDatosDirecciones] = useState<
    datosDireccionesProps[]
  >([]);
  const [datosCorreos, setDatosCorreos] = useState<datosCorreosProps[]>([]);
  const [datosTelefonos, setDatosTelefonos] = useState<datosTelefonosProps[]>(
    []
  );
  const [datosIndependientes, setDatosIndependientes] = useState<
    datosIndependientesProps[]
  >([]);
  const [datosLaborales, setDatosLaborales] = useState<datosLaboralesProps>(
    datosLaboralesDefaultValues
  );
  const [datosHistorico, setDatosHistorico] = useState<datosHistoricoProps[]>(
    []
  );

  const [datosDeudas, setDatosDeudas] = useState<datosDeudasProps[]>([]);
  const [datosResumen, setDatosResumen] = useState<datosResumenProps[]>([]);
  const [datosFamiliares, setDatosFamiliares] = useState<
    datosFamiliaresProps[]
  >([]);
  const activeButtonStyle = {
    "--tw-bg-opacity": 1,
    backgroundColor: "hsl(var(--n) / var(--tw-bg-opacity))",
    "--tw-text-opacity": 1,
    color: "hsl(var(--nc) / var(--tw-text-opacity))",
  };
  useEffect(() => {
    if (
      typeof infoPersonaData === "object" &&
      "generales" in infoPersonaData!
    ) {
      setDatosGenerales(infoPersonaData.generales as datosGeneralesProps);
    }
    if (
      typeof infoPersonaData === "object" &&
      "direcciones" in infoPersonaData!
    ) {
      setDatosDirecciones(
        infoPersonaData.direcciones as datosDireccionesProps[]
      );
    }
    if (typeof infoPersonaData === "object" && "correos" in infoPersonaData!) {
      setDatosCorreos(infoPersonaData.correos as datosCorreosProps[]);
    }
    if (
      typeof infoPersonaData === "object" &&
      "telefonos" in infoPersonaData!
    ) {
      setDatosTelefonos(infoPersonaData.telefonos as datosTelefonosProps[]);
    }
    if (typeof infoPersonaData === "object" && "empresas" in infoPersonaData!) {
      setDatosIndependientes(
        infoPersonaData.empresas as datosIndependientesProps[]
      );
    }
    if (typeof infoPersonaData === "object" && "essalud" in infoPersonaData!) {
      setDatosLaborales(infoPersonaData.essalud as datosLaboralesProps);
    }
    if (typeof infoPersonaData === "object" && "sbs" in infoPersonaData!) {
      setDatosHistorico(infoPersonaData.sbs as datosHistoricoProps[]);
    }
    if (
      typeof infoPersonaData === "object" &&
      "utilizacion" in infoPersonaData!
    ) {
      setDatosDeudas(infoPersonaData.utilizacion as datosDeudasProps[]);
    }
    if (
      typeof infoPersonaData === "object" &&
      "resumen_financiero" in infoPersonaData!
    ) {
      setDatosResumen(
        infoPersonaData.resumen_financiero as datosResumenProps[]
      );
    }
    if (
      typeof infoPersonaData === "object" &&
      "familiares" in infoPersonaData!
    ) {
      setDatosFamiliares(infoPersonaData.familiares as datosFamiliaresProps[]);
    }
  }, [infoPersonaData]);

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
      <div className="mx-auto mb-4 object-center w-11/12 flex justify-center items-center">
        <ul className="menu  menu-vertical lg:menu-horizontal bg-base-200 rounded-box">
          <li>
            <button
              style={currentTab === "datosGenerales" ? activeButtonStyle : {}}
              onClick={() => setCurrentTab("datosGenerales")}
            >
              Datos Generales
            </button>
          </li>
          <li>
            <button
              style={currentTab === "datosLaborales" ? activeButtonStyle : {}}
              onClick={() => setCurrentTab("datosLaborales")}
            >
              Datos Laborales
            </button>
          </li>
          <li>
            <button
              style={currentTab === "datosHistorico" ? activeButtonStyle : {}}
              onClick={() => setCurrentTab("datosHistorico")}
            >
              Historico
            </button>
          </li>
          <li>
            <button
              style={currentTab === "datosDeudas" ? activeButtonStyle : {}}
              onClick={() => setCurrentTab("datosDeudas")}
            >
              Deudas
            </button>
          </li>
          <li>
            <button
              style={currentTab === "datosOtros" ? activeButtonStyle : {}}
              onClick={() => setCurrentTab("datosOtros")}
            >
              Otros
            </button>
          </li>
          <li>
            <button
              style={currentTab === "datosResumen" ? activeButtonStyle : {}}
              onClick={() => setCurrentTab("datosResumen")}
            >
              Resumen Financiero
            </button>
          </li>
        </ul>
      </div>
      <div className={`${currentTab != "datosGenerales" ? "hidden" : ""}`}>
        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">
            Datos Generales
          </div>
          <div className="collapse-content">
            <div className="card mt-2">
              <div className="row">
                <div className="flex">
                  <div className="font-medium">Nombres: </div>
                  <div className="px-8">
                    {datosGenerales.nombres} {datosGenerales.paterno}{" "}
                    {datosGenerales.materno}
                  </div>
                </div>
                <div className="flex">
                  <div className="font-medium">Documento:</div>
                  <div className="px-8">{datosGenerales.documento}</div>
                </div>
                <div className="flex">
                  <div className="font-medium">Nacimiento:</div>
                  <div className="px-8">{datosGenerales.nacimiento}</div>
                </div>

                <div className="flex">
                  <div className="font-medium">Sexo:</div>
                  <div className="px-8">
                    {datosGenerales.sexo == "1"
                      ? "Masculino"
                      : datosGenerales.sexo == "2"
                      ? "Femenino"
                      : ""}
                  </div>
                </div>

                <div className="flex">
                  <div className="font-medium">Estado Civil:</div>
                  <div className="px-8">{datosGenerales.estado_civil}</div>
                </div>

                <div className="flex">
                  <div className="font-medium">Madre:</div>
                  <div className="px-8">{datosGenerales.madre}</div>
                </div>
                <div className="flex">
                  <div className="font-medium">Padre:</div>
                  <div className="px-8">{datosGenerales.padre}</div>
                </div>
                <div className="flex">
                  <div className="font-medium">Ubigeo Nacimiento:</div>
                  <div className="px-8">{datosGenerales.lugar_nacimiento}</div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">Direcciones</div>
          <div className="collapse-content">
            <div className="card mt-2">
              <div className="overflow-x-auto">
                <table className="table">
                  {/* head */}
                  <thead>
                    <tr>
                      <th>Fecha</th>
                      <th>Tipo</th>
                      <th>Dirección</th>
                      <th>Departamento Provincia Distrito</th>
                    </tr>
                  </thead>
                  <tbody>
                    {datosDirecciones
                      ? datosDirecciones.map((direccion, index) => (
                          <tr key={`ubigeo-${index}`}>
                            <td>{direccion.fecha_data}</td>
                            <td>{direccion.origen_data}</td>
                            <td>{direccion.direccion}</td>
                            <td>{direccion.descripcion_ubigeo}</td>
                          </tr>
                        ))
                      : null}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">Correos</div>
          <div className="collapse-content">
            <div className="card mt-2">
              <div className="overflow-x-auto">
                <table className="table">
                  {/* head */}
                  <thead>
                    <tr>
                      <th>Correos</th>
                    </tr>
                  </thead>
                  <tbody>
                    {datosCorreos
                      ? datosCorreos.map((correo, index) => (
                          <tr key={`correo-${index}`}>
                            <td>{correo.correo}</td>
                          </tr>
                        ))
                      : null}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">Telefonos</div>
          <div className="collapse-content">
            <div className="card mt-2">
              <div className="overflow-x-auto">
                <table className="table">
                  {/* head */}
                  <thead>
                    <tr>
                      <th>Fecha Actualización</th>
                      <th>Teléfono</th>
                      <th>Fuente</th>
                      <th>Plan</th>
                    </tr>
                  </thead>
                  <tbody>
                    {datosTelefonos
                      ? datosTelefonos.map((telefono, index) => (
                          <tr key={`telefono-${index}`}>
                            <td>{telefono.fecha_data}</td>
                            <td>{telefono.telefono}</td>
                            <td>{telefono.origen_data}</td>
                            <td>{telefono.plan}</td>
                          </tr>
                        ))
                      : null}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">Datos Sunat</div>
          {datosIndependientes
            ? datosIndependientes.map((independiente, index) => (
                <div className="collapse-content" key={`correo-${index}`}>
                  <div className="card mt-2">
                    <div className="row">
                      <div className="flex">
                        <div className="font-medium">RUC: </div>
                        <div className="px-8">{independiente.ruc}</div>
                      </div>
                      <div className="flex">
                        <div className="font-medium">Razon Social:</div>
                        <div className="px-8">{independiente.razonsocial}</div>
                      </div>
                      <div className="flex">
                        <div className="font-medium">Nombre Comercial:</div>
                        <div className="px-8">
                          {independiente.nombrecomercial}
                        </div>
                      </div>

                      <div className="flex">
                        <div className="font-medium">Giro:</div>
                        <div className="px-8">{independiente.giro}</div>
                      </div>

                      <div className="flex">
                        <div className="font-medium">Estado :</div>
                        <div className="px-8">{independiente.estado}</div>
                      </div>

                      <div className="flex">
                        <div className="font-medium">Tipo:</div>
                        <div className="px-8">{independiente.tipo}</div>
                      </div>
                      <div className="flex">
                        <div className="font-medium">Condicion:</div>
                        <div className="px-8">{independiente.condicion}</div>
                      </div>
                      <div className="flex">
                        <div className="font-medium">Estado:</div>
                        <div className="px-8">{independiente.estado}</div>
                      </div>
                    </div>
                  </div>
                </div>
              ))
            : null}
        </div>
      </div>

      <div className={`${currentTab != "datosLaborales" ? "hidden" : ""}`}>
        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">
            Datos Laborales
          </div>
          <div className="collapse-content">
            <div className="card mt-2">
              <div className="overflow-x-auto">
                <table className="table">
                  {/* head */}
                  <thead>
                    <tr>
                      <th>RUC</th>
                      <th>Empresa</th>
                      <th>Fecha Reporte</th>
                      <th>Condicion</th>
                      <th>Sueldo</th>
                    </tr>
                  </thead>
                  <tbody>
                    {datosLaborales.mes1
                      ? datosLaborales.mes1.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes2
                      ? datosLaborales.mes2.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes3
                      ? datosLaborales.mes3.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes4
                      ? datosLaborales.mes4.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes5
                      ? datosLaborales.mes5.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes6
                      ? datosLaborales.mes6.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes7
                      ? datosLaborales.mes7.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes8
                      ? datosLaborales.mes8.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes9
                      ? datosLaborales.mes9.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes10
                      ? datosLaborales.mes10.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes11
                      ? datosLaborales.mes11.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                    {datosLaborales.mes12
                      ? datosLaborales.mes12.map((laboral, index) => (
                          <tr key={`laboralmes1-${index}`}>
                            <td>{laboral.ruc}</td>
                            <td>{laboral.nombre_empresa}</td>
                            <td>{laboral.fecha}</td>
                            <td>{laboral.situacion}</td>
                            <td>
                              {String(Number(laboral.sueldo) * 55.55).substring(
                                0,
                                7
                              )}
                            </td>
                          </tr>
                        ))
                      : null}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div className={`${currentTab != "datosHistorico" ? "hidden" : ""}`}>
        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">Historico</div>
          <div className="collapse-content">
            <div className="card mt-2">
              <div className="overflow-x-auto">
                <table className="table">
                  {/* head */}
                  <thead>
                    <tr>
                      <th rowSpan={2}>Fecha</th>
                      <th rowSpan={2}>Mes</th>
                      <th rowSpan={2}>Sem. Act.</th>

                      <th colSpan={2} className="text-center">
                        Superintendencia de Banca y Seguros (SBS y Microf.)
                      </th>
                    </tr>
                    <tr>
                      <th>N. Enti.</th>
                      <th>Deuda Total</th>
                      <th>Disponible TC</th>
                      <th className="bg-green-500 text-white">% NOR</th>
                      <th className="bg-yellow-300 text-white">% CPP</th>
                      <th className="bg-yellow-500 text-white">% DEF</th>
                      <th className="bg-red-500 text-white">% DUD</th>
                      <th className="bg-black-400 text-white">% PER</th>
                    </tr>
                  </thead>
                  <tbody>
                    {datosHistorico
                      ? datosHistorico.map((historico, index) => (
                          <tr key={`historico-${index}`}>
                            <td>{historico.fecha_reporte_sbs}</td>
                            <td>
                              {historico.fecha_reporte_sbs.substring(4, 6)}
                            </td>
                            <td>{historico.cant_empresas}</td>
                            <td>{historico.cant_empresas}</td>
                            <td>{historico.deuda_total}</td>
                            <td>{historico.disponible}</td>
                            <td>{historico.calificacion_normal}</td>
                            <td>{historico.calificacion_cpp}</td>
                            <td>{historico.calificacion_deficiente}</td>
                            <td>{historico.calificacion_dudoso}</td>
                            <td>{historico.calificacion_perdida}</td>
                          </tr>
                        ))
                      : null}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div className={`${currentTab != "datosDeudas" ? "hidden" : ""}`}>
        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">
            Utilización de lineas de credito
          </div>
          <div className="collapse-content">
            <div className="card mt-2">
              <div className="overflow-x-auto">
                <table className="table">
                  {/* head */}
                  <thead>
                    <tr>
                      <th>Nombre de la Entidad</th>
                      <th>Linea Aprobada</th>
                      <th>Linea No Utilizada</th>
                      <th>Linea Utilizada</th>
                    </tr>
                  </thead>
                  <tbody>
                    {datosDeudas
                      ? datosDeudas.map((deuda, index) => (
                          <tr key={`deuda-${index}`}>
                            <td>{deuda.empresa}</td>
                            <td>{deuda.linea_otorgada}</td>
                            <td>{deuda.linea_no_utilizada}</td>
                            <td>{deuda.linea_utilizada}</td>
                          </tr>
                        ))
                      : null}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>

        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">
            Detalle de Deuda
          </div>
          <div className="collapse-content">
            <div className="card mt-2">
              <div className="overflow-x-auto">
                <table className="table">
                  {/* head */}
                  <thead>
                    <tr>
                      {datosHistorico
                        ? datosHistorico.map((Historico, idx) => {
                            if (idx <= 2) {
                              return (
                                <th>
                                  {Historico.fecha_reporte_sbs.substring(0, 6)}

                                  {Historico.sbs_detalle
                                    ? Historico.sbs_detalle.map(
                                        (DetalleHistorico, index) => (
                                          <tbody>
                                            <tr
                                              key={`detallehistorico-${index}`}
                                            >
                                              <td>
                                                {DetalleHistorico.entidad}
                                              </td>
                                              <td>
                                                {DetalleHistorico.tipo_credito}
                                              </td>
                                              <td>{DetalleHistorico.monto}</td>
                                            </tr>
                                          </tbody>
                                        )
                                      )
                                    : null}
                                </th>
                              );
                            }
                          })
                        : null}
                    </tr>
                  </thead>
                </table>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div className={`${currentTab != "datosOtros" ? "hidden" : ""}`}>
        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">Familiares</div>
          <div className="collapse-content">
            <div className="card mt-2">
              <div className="overflow-x-auto">
                <table className="table">
                  {/* head */}
                  <thead>
                    <tr>
                      <th>Documento</th>
                      <th>Nombres y Apellidos</th>
                      <th>Fecha de Nacimiento</th>
                      <th>Relacion</th>
                    </tr>
                  </thead>
                  <tbody>
                    {datosFamiliares
                      ? datosFamiliares.map((familiar, index) => (
                          <tr key={`familiar-${index}`}>
                            <td>{familiar.documento_familiar}</td>
                            <td>
                              {familiar.paterno_familiar}{" "}
                              {familiar.materno_familiar}{" "}
                              {familiar.nombres_familiar}
                            </td>
                            <td>{familiar.nacimiento_familiar}</td>
                            <td>{familiar.tipo_relacion}</td>
                          </tr>
                        ))
                      : null}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div className={`${currentTab != "datosResumen" ? "hidden" : ""}`}>
        <div
          tabIndex={0}
          className="collapse collapse-open collapse-arrow border border-base-300 bg-base-200 w-11/12 mx-auto mb-4"
        >
          <div className="collapse-title text-xl font-medium">
            Resumen Financiero
          </div>
          <div className="collapse-content">
            <div className="card mt-2">
              <div className="overflow-x-auto">
                <table className="table">
                  {/* head */}
                  <thead>
                    <tr>
                      <th>Entidad</th>
                      <th>Linea Aprobada</th>
                      <th>Préstamo</th>
                      <th>TC</th>
                      <th>Hipotecario</th>
                      <th>Auto</th>
                      <th>Comercial</th>
                      <th>Otros</th>
                      <th>Linea Disponible</th>
                    </tr>
                  </thead>
                  <tbody>
                    {datosResumen
                      ? datosResumen.map((resumen, index) => (
                          <tr key={`resumen-${index}`}>
                            <td>{resumen.entidad}</td>
                            <td>{resumen.linea_aprobada}</td>
                            <td>{resumen.prestamo}</td>
                            <td>{resumen.tarjeta}</td>
                            <td>{resumen.vehicular}</td>
                            <td>{resumen.hipotecario}</td>
                            <td>{resumen.comercial}</td>
                            <td>{resumen.otros}</td>
                            <td>{resumen.linea_disponible}</td>
                          </tr>
                        ))
                      : null}
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}
interface datosGeneralesProps {
  nombres: string;
  paterno: string;
  materno: string;
  documento: string;
  nacimiento: string;
  sexo: string;
  estado_civil: string;
  madre: string;
  padre: string;
  ubigeonacimiento: string;
  lugar_nacimiento: string;
}

const datosGeneralesDefaultValues: datosGeneralesProps = {
  nombres: "",
  paterno: "",
  materno: "",
  documento: "",
  nacimiento: "",
  sexo: "",
  estado_civil: "",
  madre: "",
  padre: "",
  ubigeonacimiento: "",
  lugar_nacimiento: "",
};
interface datosDireccionesProps {
  ubigeo: string;
  descripcion_ubigeo: string;
  direccion: string;
  origen_data: string;
  fecha_data: string;
}
interface datosCorreosProps {
  correo: string;
}
interface datosTelefonosProps {
  telefono: string;
  tipo_telefono: string;
  plan: string;
  modelo_celular: string;
  origen_data: string;
  fecha_data: string;
}
interface datosIndependientesProps {
  ruc: string;
  razonsocial: string;
  nombrecomercial: string;
  tipo: string;
  fecha_inscripcion: string;
  estado: string;
  fecha_baja: string;
  condicion: string;
  giro: string;
  cargo: string;
  ubigeo: string;
  direccion: string;
  distrito: string;
  provincia: string;
  departamento: string;
}
interface datosLaboralesProps {
  mes1: datosLaboralesMesProps[];
  mes2: datosLaboralesMesProps[];
  mes3: datosLaboralesMesProps[];
  mes4: datosLaboralesMesProps[];
  mes5: datosLaboralesMesProps[];
  mes6: datosLaboralesMesProps[];
  mes7: datosLaboralesMesProps[];
  mes8: datosLaboralesMesProps[];
  mes9: datosLaboralesMesProps[];
  mes10: datosLaboralesMesProps[];
  mes11: datosLaboralesMesProps[];
  mes12: datosLaboralesMesProps[];
}
const datosLaboralesDefaultValues: datosLaboralesProps = {
  mes1: [],
  mes2: [],
  mes3: [],
  mes4: [],
  mes5: [],
  mes6: [],
  mes7: [],
  mes8: [],
  mes9: [],
  mes10: [],
  mes11: [],
  mes12: [],
};
interface datosLaboralesMesProps {
  fecha: string;
  ruc: string;
  nombre_empresa: string;
  sueldo: string;
  situacion: string;
  ubigeo: string;
  direccion: string;
  distrito: string;
  provincia: string;
  departamento: string;
}
interface datosHistoricoProps {
  fecha_reporte_sbs: string;
  cant_empresas: string;
  calificacion_normal: string;
  calificacion_cpp: string;
  calificacion_deficiente: string;
  calificacion_dudoso: string;
  calificacion_perdida: string;
  deuda_total: string;
  disponible: string;
  sbs_detalle: datosHistoricoDetalleProps[];
}
interface datosHistoricoDetalleProps {
  entidad: string;
  tipo_credito: string;
  detalle: string;
  monto: string;
  dias_atraso: string;
}

interface datosDeudasProps {
  empresa: string;
  linea_otorgada: string;
  linea_no_utilizada: string;
  linea_utilizada: string;
}

interface datosResumenProps {
  entidad: string;
  linea_aprobada: string;
  tarjeta: string;
  linea_disponible: string;
  vehicular: string;
  hipotecario: string;
  comercial: string;
  prestamo: string;
  convenio: string;
  otros: string;
}
interface datosFamiliaresProps {
  documento_familiar: string;
  paterno_familiar: string;
  materno_familiar: string;
  nombres_familiar: string;
  nacimiento_familiar: string;
  tipo_relacion: string;
}
export default SecDatosGenerales;
