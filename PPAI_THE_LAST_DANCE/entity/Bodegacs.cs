using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    

    public class Bodega
    {
        private string coordenadasUbicacion;
        private string descripcion;
        private DateTime fechaUltimaActualizacion;
        private string historia;
        private string nombre;
        private string periodoActualizacion;

        private List<Vino> vinos = new List<Vino>();
        private List<Siguiendo> seguidores = new List<Siguiendo>();
        private List<Maridaje> maridajes = new List<Maridaje>();

        public string GetNombre() => nombre;
        public void ActualizarVino() { }
        public bool EsActualizable() => true;
        public void SetFechaActualizacion(DateTime fecha) => fechaUltimaActualizacion = fecha;
        public bool TieneSetVino() => true;
        public void ValidarFechaActual() { }
    }

}
