import BarraBusquedaDNI from "../components/organisms/BarraBusquedaDNI";
import SecDatosGenerales from "../components/organisms/BusquedaDNIDatosGenerales";

function BusquedaDNI() {
  return (
    <div>
      <BarraBusquedaDNI />
      <div className="divider"></div>
      <SecDatosGenerales />
    </div>
  );
}

export default BusquedaDNI;
