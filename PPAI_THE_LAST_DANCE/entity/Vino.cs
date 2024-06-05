using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{


    public class Vino
    {
        private int anada;
        private DateTime bodegaActualizacion;
        private string imagenEtiqueta;
        private string nombre;
        private string notaDeCataBodega;
        private int precioARS;
        private List<Maridaje> maridaje;
        private List<TipoUva> tipoUva;


        private Bodega bodega;
        private List<Varietal> varietales = new List<Varietal>();

        
        public Vino()
        {

        }

        public Vino(int anada, DateTime bodegaActualizacion, string imagenEtiqueta, string nombre, string notaDeCataBodega, int precioARS, List<Maridaje> maridaje, List<TipoUva> tipoUva)
        {
            this.anada = anada;
            this.bodegaActualizacion = bodegaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.maridaje = maridaje;
            this.tipoUva = tipoUva;
        }

        public void CrearVarietal() { }
        public void New() { }
        public DateTime SetFechaActualizacion(DateTime fecha) => bodegaActualizacion = fecha;
        public void SetImagenEtiqueta(string imagen) => imagenEtiqueta = imagen;
        public void SetNotaCata(string nota) { }
        public void SetPrecio(int precio) => precioARS = precio;
        public bool SosBodega() => true;
        public bool SosParaActualizar() => true;

        public string Nombre { get => nombre; set => nombre = value; } //crear otros
        public int Precio { get => precioARS; set => precioARS = value; }
        public int Anada { get => anada; set => anada = value; }
        public DateTime BodegaActualizacion { get => bodegaActualizacion; set => bodegaActualizacion = value; }
        public string ImagenEtiqueta { get => imagenEtiqueta; set => imagenEtiqueta = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
        public int PrecioARS { get => precioARS; set => precioARS = value; }
        public List<Maridaje> Maridaje { get => maridaje; set => maridaje = value; }
        public List<TipoUva> TipoUva { get => tipoUva; set => tipoUva = value; }

        public Boolean sosDeBodega(DatosEntrantesSistemaBodega vino)
        {
            if (this.Nombre == vino.Nombre)
            {
                return true;
            }
            return false;
        }

        public Vino crearVino(List<Maridaje> maridajes, List<TipoUva> tiposuva, DatosEntrantesSistemaBodega vino)
        {
            this.anada = vino.Añada;
            this.imagenEtiqueta = vino.ImagenEtiqueta;
            this.nombre = vino.Nombre;
            this.notaDeCataBodega = vino.NotaDeCataBodega;
            this.precioARS = vino.PrecioARS;
            this.maridaje = maridajes;
            this.varietales = crearVarietales(tiposuva, vino);
            this.bodegaActualizacion = DateTime.Now;

            return this;
        }

        public List<Varietal> crearVarietales(List<TipoUva> tiposUvas, DatosEntrantesSistemaBodega vino)
        {

            List<Varietal> Rvarietal = new List<Varietal>();
            foreach (TipoUva tipoUva in tiposUvas)
            {
                foreach (DatosEntrantesVarietales dato in vino.Varietal)
                {
                    if (tipoUva.Nombre == dato.TipoUva)
                    {
                        Rvarietal.Add(new Varietal(dato.Descripcion, dato.PorcentajeVarietal, tipoUva));
                    }
                }
            }
            return Rvarietal;
        }
    }
}
