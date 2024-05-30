using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Bodega
    {
        public string CoordenadasUbicacion { get; set; }
        public string Descripcion { get; set; }
        public string Historia { get; set; }
        public string Nombre { get; set; }
        public DateTime PeriodoActualizacion { get; set; }

        public void ContarReseñas() { /* implementación */ }
        public void MostrarTodosVinos() { /* implementación */ }

        public RegionVitivinicola Region { get; set; }
    }
}
