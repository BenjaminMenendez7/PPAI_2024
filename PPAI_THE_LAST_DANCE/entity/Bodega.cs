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
        private int periodoActualizacion;

        private List<Vino> vinos = new List<Vino>();
        private List<Siguiendo> seguidores = new List<Siguiendo>();
        private List<Maridaje> maridajes = new List<Maridaje>();




        public Bodega(string coordenadasUbicacion, string descripcion, DateTime fechaUltimaActualizacion, string historia, string nombre, int periodoActualizacion)
        {
            this.coordenadasUbicacion = coordenadasUbicacion;
            this.descripcion = descripcion;
            this.fechaUltimaActualizacion = fechaUltimaActualizacion;
            this.historia = historia;
            this.nombre = nombre;
            this.periodoActualizacion = periodoActualizacion;

        }

        

        public string GetNombre() => nombre;
        public string GetCoordenadas() => coordenadasUbicacion;
        public string GetDescripcion() => descripcion;
        public DateTime GetFecha() => fechaUltimaActualizacion;
        public string GetHistoria() => historia;
        public int GetPeriodoActualizacion() => periodoActualizacion;
        public void ActualizarVino() { }
        public bool EsActualizable() => true;
        public void SetFechaActualizacion(DateTime fecha) => fechaUltimaActualizacion = fecha;
        public bool TieneSetVino() => true;
        public void ValidarFechaActual() { }
    }

}
