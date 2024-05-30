using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Pais
    {
        public string Nombre { get; set; }

        public void ContarBodegas() { /* implementación */ }
        public List<Provincia> Provincias { get; set; } = new List<Provincia>();
    }
}
