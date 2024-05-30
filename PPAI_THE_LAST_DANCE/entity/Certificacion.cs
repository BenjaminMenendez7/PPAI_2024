using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Certificacion
    {
        public string AdjuntoURL { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public string InstitucionOtorgante { get; set; }

        public void EsEnPeriodo() { /* implementación */ }
        public void MostrarInstitucion() { /* implementación */ }
        public void VerAdjunto() { /* implementación */ }

        public Sommelier Sommelier { get; set; }
    }
}
