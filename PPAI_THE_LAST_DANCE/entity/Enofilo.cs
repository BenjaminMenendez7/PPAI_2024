using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Enofilo
    {
        private string apellido;
        private string imagenPerfil;
        private string nombre;

        private Usuario usuario;

        private List<Vino> favorito;
        private List<Siguiendo> seguido;

        // getters and setters
        public string Apellido { get => apellido; set => apellido = value; }
        public string ImagenPerfil { get => imagenPerfil; set => imagenPerfil = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Vino> Favorito { get => favorito; set => favorito = value; }
        public List<Siguiendo> Seguido { get => seguido; set => seguido = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public Enofilo(string apellido, string imagenPerfil, string nombre, Usuario usu)
        {
            this.Apellido = apellido;
            this.ImagenPerfil = imagenPerfil;
            this.Nombre = nombre;
            this.usuario = usu;
            this.Seguido = new List<Siguiendo>();
        }


        // busca si el enofino sigue esa bodega en tal caso retorna el nombre para enviarle una notificacion 
        public string sosSeguidorBodega(Bodega bodega)
        {
            string nombre = this.buscarSuscripcion(bodega); //comparar a nivel de objeto
            if (nombre != null)
            {
                return nombre;
            }
            return null;
        }

        // se fija en todos los objetos siguiendo si alguno de esos apunta a la bodega que se pasa por parametro
        public string buscarSuscripcion(Bodega bodega)
        {
            if (this.Seguido != null)
            {
                foreach (Siguiendo sig in this.Seguido)
                {
                    if (sig.sosDeBodega(bodega))
                    {
                        return usuario.getNombre();
                    }
                }
            }
            return null;
        }
    }

}
