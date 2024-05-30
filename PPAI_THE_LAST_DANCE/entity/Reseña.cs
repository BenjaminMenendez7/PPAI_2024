using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Reseña
    {
        public string Comentario { get; set; }
        public bool EsPremium { get; set; }
        public DateTime FechaReseña { get; set; }
        public int Puntaje { get; set; }

        public void SosPremium() { /* implementación */ }
        public void SosDeEnofilo() { /* implementación */ }
        public void SosDeSommelier() { /* implementación */ }

        public Vino Vino { get; set; }
    }
}
