using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Vino
    {
        public string Añada { get; set; }
        public string ImagenEtiqueta { get; set; }
        public string Nombre { get; set; }
        public string NotaDeCataBodega { get; set; }
        public decimal PrecioARS { get; set; }

        public void CalcularRanking() { /* implementación */ }
        public void CompararEtiqueta() { /* implementación */ }
        public void EsDeBodega() { /* implementación */ }
        public void EsDeRegionVitivinicola() { /* implementación */ }

        public Bodega Bodega { get; set; }
        public List<Reseña> Reseñas { get; set; } = new List<Reseña>();
        public Varietal Varietal { get; set; }
    }
}
