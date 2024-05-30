using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Sommelier : Usuario
    {
        public DateTime FechaValidacion { get; set; }
        public string NotaPresentacion { get; set; }

        public void ConocerCertificaciones() { /* implementación */ }
        public void ValidarSommelier() { /* implementación */ }

        public List<Certificacion> Certificaciones { get; set; } = new List<Certificacion>();
    }
}
