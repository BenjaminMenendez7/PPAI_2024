using PPAI_THE_LAST_DANCE.boundary;
using PPAI_THE_LAST_DANCE.entity;
using System;
using System.Collections.Generic;
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
        private DateTime fechaHoraActual { get; set; }
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
            //while (true) // mientras haya bodegas
            //{

            //}
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
