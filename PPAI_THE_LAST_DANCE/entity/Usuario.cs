using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Usuario
    {
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public bool Premium { get; set; }

        public void EsPremium() { /* implementación */ }
        public void EsTuUsuario() { /* implementación */ }
        public void MostrarNombre() { /* implementación */ }

        public List<Reseña> Reseñas { get; set; } = new List<Reseña>();
        public List<Enofilo> Amigos { get; set; } = new List<Enofilo>();
    }
}
