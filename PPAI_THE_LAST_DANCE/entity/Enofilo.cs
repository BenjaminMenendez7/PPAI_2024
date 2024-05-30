using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Enofilo : Usuario
    {
        private string apellido;
        private string imagenPerfil;

        public string ObtenerNombreUsuario() => $"{nombre} {apellido}";
        public bool SosSeguidorBodega() => false;
    }

}
