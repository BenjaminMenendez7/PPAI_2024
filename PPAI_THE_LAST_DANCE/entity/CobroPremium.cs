using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class CobroPremium
    {
        public bool EsAnual { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string NroOperacionMercadoPago { get; set; }
    }
}
