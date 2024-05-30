using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Provincia
    {
        public string Nombre { get; set; }

        public void ContarRegiones() { /* implementación */ }
        public void MostrarRegiones() { /* implementación */ }
        public List<RegionVitivinicola> Regiones { get; set; } = new List<RegionVitivinicola>();
    }
}
