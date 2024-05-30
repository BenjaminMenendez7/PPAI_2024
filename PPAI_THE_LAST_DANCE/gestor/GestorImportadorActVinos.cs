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
        private List<Bodega> bodegas = new List<Bodega>();
        private Bodega bodegaSeleccionada;
        private List<Vino> datosVinosImportados = new List<Vino>();
        private DateTime fechaHoraActual;
        private List<Maridaje> maridajes = new List<Maridaje>();
        private List<TipoUva> tiposUva = new List<TipoUva>();

        

        public void ActualizarFechaActualizacionBodega() { }
        public void ActualizarCrearVinos() { }
        public void BuscarBodegaActualizacionDisp() { }
        public void BuscarMaridaje() { }
        public void BuscarSeguidoresBodega() { }
        public void CrearDTOvino() { }
        public void CrearVino() { }
        public void FinCU() { }
        public DateTime GetFechaHoraActual() => DateTime.Now;
        public void ObtenerActualizacionesBodega() { }
        public void OpcionImportarActualizacionVinos() { }
        public void ObtenerVinosActualizados() { }
        public void TomarSeleccionBodega() { }
    }

}
