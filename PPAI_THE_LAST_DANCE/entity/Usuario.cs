using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Usuario
    {
        private string nombre;
        private string contraseña;
        private Boolean premium;

        public Usuario(string nombre, string contraseña, bool premium)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.premium = premium;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public bool Premium { get => premium; set => premium = value; }

        public string getNombre()
        {
            return Nombre;
        }
    }

}
