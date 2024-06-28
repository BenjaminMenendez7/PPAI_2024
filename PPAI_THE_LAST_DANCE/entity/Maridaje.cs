using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Maridaje
    {
        private string descripcion;
        private string nombre;

        private List<Bodega> bodegas = new List<Bodega>();

        public Maridaje(string descripcion, string nombre)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }

        public Boolean SosMaridaje(String maridaje) 
        {
            if (this.nombre == maridaje)
            {
                return true;
            }
            return false;
        }
    }

}
