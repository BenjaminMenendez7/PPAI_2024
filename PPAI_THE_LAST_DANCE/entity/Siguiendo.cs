using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    
    public class Siguiendo
    {
        private DateTime fechaInicio;
        private DateTime? fechaFin;
        private Bodega bodega;

        public Siguiendo(DateTime fechaInicio, DateTime? fechaFin, Bodega bodega)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.bodega = bodega;
        }

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime? FechaFin { get => fechaFin; set => fechaFin = value; }
        public Bodega Bodega { get => bodega; set => bodega = value; }

        // compara si tiene una referencia a la bodega que le estoy pasando por parametro y si la fecha fin es vacia para saber
        // si dicho seguimiento no lo finalizo
        public Boolean sosDeBodega(Bodega bodega)
        {
            if (this.fechaFin == null && this.bodega == bodega)
            {
                return true;
            }
            return false;
        }
    }

}
