using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Varietal
    {
        public string Descripcion { get; set; }
        public decimal PorcentajeComposicion { get; set; }

        public void ConocerTipoUva() { /* implementación */ }
        public void EsDeTipoUva() { /* implementación */ }
        public void MostrarPorcentaje() { /* implementación */ }

        public TipoUva TipoUva { get; set; }
    }
}
