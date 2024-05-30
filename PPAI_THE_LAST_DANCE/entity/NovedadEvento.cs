using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class NovedadEvento
    {
        public string CodigoDescuentoPremium { get; set; }
        public string Descripcion { get; set; }
        public bool EsSoloPremium { get; set; }
        public DateTime FechaHoraEvento { get; set; }
        public string NombreEvento { get; set; }
        public bool EsPremium { get; set; }
        public bool EstaEnPeriodo { get; set; }

        public void MostrarDescripcion() { /* implementación */ }
    }
}
