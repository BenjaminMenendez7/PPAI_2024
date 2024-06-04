using PPAI_THE_LAST_DANCE.AccesoADatos;
using PPAI_THE_LAST_DANCE.boundary;
using PPAI_THE_LAST_DANCE.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.gestor
{
   
    public class GestorImportadorActVinos
    {
        private List<Bodega> bodegas { get; set; }
        private Bodega bodegaSeleccionada { get; set; }
        private List<Vino> datosVinosImportados { get; set; }
        private string fechaHoraActual { get; set; }
        private List<Maridaje> maridajes { get; set; }
        private List<TipoUva> tiposUva { get; set; }
        private pantImportadoraActVinos pantallaImportadoraActVinos;


        public GestorImportadorActVinos(pantImportadoraActVinos pantalla)
        {
            pantallaImportadoraActVinos = pantalla;
            
        }
        

        public void ActualizarFechaActualizacionBodega() { }
        public void ActualizarCrearVinos() { }
        public List<Bodega> BuscarBodegaActualizacionDisp() 
        {
           ADGestor ad_gestor = new ADGestor();
           DataTable tabla = new DataTable();
           tabla = ad_gestor.buscarBodegasConActualizacionDisp();

            List<Bodega> listaBodegas = new List<Bodega>();

            foreach (DataRow row in tabla.Rows)
            {
                Bodega bodega = new Bodega();
                bodega.CoordenadasUbicacion = row["coordenadasUbicacion"].ToString();
                bodega.Descripcion = row["descripcion"].ToString();
                bodega.FechaUltimaActualizacion = row["fechaUltimaActualizacion"].ToString();
                bodega.Historia = row["historia"].ToString();
                bodega.Nombre = row["nombre"].ToString();
                bodega.PeriodoActualizacion = 2;//row["periodoActualizacion"];

                if (bodega.EsActualizable()) 
                {
                    listaBodegas.Add(bodega);

                }
            }
 
            return listaBodegas;
        }
        public void BuscarMaridaje() { }
        public void BuscarSeguidoresBodega() { }
        public void CrearDTOvino() { }
        public void CrearVino() { }
        public void FinCU() { }
        public DateTime GetFechaHoraActual() => DateTime.Now;
        public void ObtenerActualizacionesBodega() 
        {
            //List<Vino> v = new List<Vino>();

            //InterfazAPIBodega interfazapi = new InterfazAPIBodega(v);
            ///interfazapi.ObtenerActualizacionesBodega();
        }
        public void OpcionImportarActualizacionVinos() 
        {
            this.bodegas = BuscarBodegaActualizacionDisp();
        }
        public void ObtenerVinosActualizados() { }
        public void TomarSeleccionBodega() 
        {
            ObtenerActualizacionesBodega();
        }
    }

}
