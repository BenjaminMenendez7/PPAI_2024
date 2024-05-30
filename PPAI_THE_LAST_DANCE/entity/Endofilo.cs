using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Enofilo : Usuario
    {
        public string Apellido { get; set; }
        public string ImagenPerfil { get; set; }

        public void MostrarAmigosSeguidos() { /* implementación */ }
        public void MostrarColeccionFavoritos() { /* implementación */ }

        public List<Vino> Favoritos { get; set; } = new List<Vino>();
    }
}
