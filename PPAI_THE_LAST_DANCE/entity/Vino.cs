using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    

    public class Vino
    {
        private string anada;
        private string bodegaActualizacion;
        private string imagenEtiqueta;
        private string nombre;
        private string notaDeCataBodega;
        private decimal precioARS;

        private Bodega bodega;
        private List<Varietal> varietales = new List<Varietal>();

        public Vino(string anada, string bodegaActualizacion, string imagenEtiqueta, string nombre, string notaDeCataBodega, decimal precioARS)
        {
            this.anada = anada;
            this.bodegaActualizacion = bodegaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
        }

        public void CrearVarietal() { }
        public void New() { }
        public void SetFechaActualizacion(string fecha) => notaDeCataBodega = fecha;
        public void SetImagenEtiqueta(string imagen) => imagenEtiqueta = imagen;
        public void SetNotaCata(string nota) { }
        public void SetPrecio(decimal precio) => precioARS = precio;
        public bool SosBodega() => true;
        public bool SosParaActualizar() => true;
    }

}
