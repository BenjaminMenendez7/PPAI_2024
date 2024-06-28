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
        private Enofilo amigo;

        public Siguiendo(DateTime fechaInicio, DateTime? fechaFin)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            
        }

        public Bodega Bodega
        {
            get { return bodega; }
            set
            {
                if (amigo != null)
                    throw new InvalidOperationException("La relación con Enofilo ya está establecida.");
                bodega = value;
            }
        }

        public Enofilo Enofilo
        {
            get { return amigo; }
            set
            {
                if (bodega != null)
                    throw new InvalidOperationException("La relación con Bodega ya está establecida.");
                amigo = value;
            }
        }

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime? FechaFin { get => fechaFin; set => fechaFin = value; }
       

        // compara si tiene una referencia a la bodega pasada por parametro y si la fecha fin es vacia, para saber si el seguimiento no finalizo
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
