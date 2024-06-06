using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Enofilo
    {
        private string nombre;
        private string apellido;
        private string imagenPerfil;
        private List<Siguiendo> BodegasSeguidas;
        private Usuario usuario;

        public Enofilo(string nombre, string apellido, string imagenPerfil, List<Siguiendo> bodegasSeguidas, Usuario usuario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.imagenPerfil = imagenPerfil;
            BodegasSeguidas = bodegasSeguidas;
            this.usuario = usuario;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string ImagenPerfil { get => imagenPerfil; set => imagenPerfil = value; }
        public List<Siguiendo> BodegasSeguidas1 { get => BodegasSeguidas; set => BodegasSeguidas = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }


        // busca si el enofino sigue esa bodega en tal caso retorna el nombre para enviarle una notificacion push
        public string sosSeguidorBodega(Bodega bodega)
        {
            string nombre = this.buscarSuscripcion(bodega);
            if (nombre != null)
            {
                return nombre;
            }
            return null;
        }

        // se fija en todos los objetos siguiendo si alguno de esos apunta a la bodega que le estoy pasando por parametro
        public string buscarSuscripcion(Bodega bodega)
        {
            if (this.BodegasSeguidas != null)
            {
                foreach (Siguiendo sig in this.BodegasSeguidas)
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
