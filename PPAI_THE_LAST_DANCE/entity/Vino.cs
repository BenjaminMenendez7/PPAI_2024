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
        private DateTime bodegaActualizacion;
        private string imagenEtiqueta;
        private string nombre;
        private string notaDeCataBodega;
        private int precioARS;
        private List<Maridaje> maridaje;
        private List<Varietal> varietales = new List<Varietal>();
        private Bodega bodega;



        public Vino(string anada, DateTime bodegaActualizacion, string imagenEtiqueta, string nombre, string notaDeCataBodega, int precioARS, Bodega bodega)
        {
            this.anada = anada;
            this.bodegaActualizacion = bodegaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.Bodega = bodega;
            this.maridaje = new List<Maridaje>();
            this.varietales = new List<Varietal>();
        }
        public Vino()
        {
        }
        public string Anada { get => anada; set => anada = value; }
        public DateTime BodegaActualizacion { get => bodegaActualizacion; set => bodegaActualizacion = value; }
        public string ImagenEtiqueta { get => imagenEtiqueta; set => imagenEtiqueta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
        public int PrecioARS { get => precioARS; set => precioARS = value; }
        public List<Maridaje> Maridaje { get => maridaje; set => maridaje = value; }
        public List<Varietal> Varietales { get => varietales; set => varietales = value; }
        public Bodega Bodega { get => bodega; set => bodega = value; }

        public void CrearVarietal() { }
        public void New() { }
        public DateTime SetFechaActualizacion(DateTime fecha) => bodegaActualizacion = fecha;
        public void SetImagenEtiqueta(string imagen) => imagenEtiqueta = imagen;
        public void SetNotaCata(string nota) { }
        public void SetPrecio(int precio) => precioARS = precio;


        public Boolean sosDeBodega(string nombreVino) 
        {
            if (this.Nombre == nombreVino)
            {
                return true;
            }
            return false;
        }

        public void crearVino(string añada, DateTime fecha, string img, string nombre, string nota, int precio, List<Maridaje> maridajesParaNuevoVino, List<TipoUva> tipoUvasParaNuevoVino, List<string[]> varietales, Bodega b)
        {
            Vino nuevoVino = new Vino(añada, fecha, img, nombre, nota, precio, b);
            nuevoVino.Maridaje = maridajesParaNuevoVino;
            nuevoVino.crearVarietal(varietales, tipoUvasParaNuevoVino);

        }

        public void crearVarietal(List<string[]> varietales, List<TipoUva> tiposDeUva)
        {
            foreach (string[] varietal in varietales)
            {
                string nV = varietal[0];
                string dV = varietal[1];
                int pC = int.Parse(varietal[2]);
                TipoUva uva = new TipoUva();
                for (int i = 0; i < tiposDeUva.Count; i++)
                {
                    uva = tiposDeUva[i];
                }
                Varietal v = new Varietal(nV, dV, pC, uva);
                this.Varietales.Add(v);
            }
        }
    }
}
