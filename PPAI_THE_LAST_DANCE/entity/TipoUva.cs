using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class TipoUva
    {
        private string descripcion;
        private string nombre;

        
        public TipoUva(string descripcion, string nombre)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }

        public TipoUva() { }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Boolean SosTipoUva(string tipoUvaNuevoVino)
        {
            if (this.nombre == tipoUvaNuevoVino )
            {
                return true;
            }
            return false;
        } 
    }

}
