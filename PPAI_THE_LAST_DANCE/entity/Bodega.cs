using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Bodega
    {
        private string descripcion;
        private DateTime fechaUltimaActualizacion;
        private string historia;
        private string nombre;
        private int periodoActualizacion;
        private List<Vino> vinos;

        public Bodega(string nombre, string descripcion, DateTime fechaUltimaActualizacion, int periodoActualizacion, string historia)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fechaUltimaActualizacion = fechaUltimaActualizacion;
            this.periodoActualizacion = periodoActualizacion;
            this.historia = historia;
            this.vinos = new List<Vino>();

        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaUltimaActualizacion { get => fechaUltimaActualizacion; set => fechaUltimaActualizacion = value; }
        public string Historia { get => historia; set => historia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PeriodoActualizacion { get => periodoActualizacion; set => periodoActualizacion = value; }
        public List<Vino> Vinos { get => vinos; set => vinos = value; }


        public bool EsActualizable(DateTime fechaActual)
        {
            if (ValidarFechaActual(fechaActual))
            {
                return true;
            }
            else
                return false;
        }

        private bool ValidarFechaActual(DateTime fechaActual)
        {
            DateTime fecha = FechaUltimaActualizacion;
            DateTime fechaNueva = fecha.AddMonths(PeriodoActualizacion);

            if (fechaNueva <= fechaActual)
            {
                return true;
            }
            else
                return false;

        }

        public Boolean tenesEsteVino(string nombreVino) //este
        {
            foreach (Vino vinoDeBodega in this.vinos)
            {
                if (vinoDeBodega.sosDeBodega(nombreVino))
                {
                    return true;
                }

            }
            return false;
        }

        public void ActualizarVino(string nombre, int precio, string nota, string img, DateTime fecha)
        {
            foreach (Vino v in vinos)
            {
                if (v.sosDeBodega(nombre)) // arreglar cambiar depend
                {
                    v.SetPrecio(precio);
                    v.SetNotaCata(nota);
                    v.SetImagenEtiqueta(img);
                    v.SetFechaActualizacion(fecha);
                }
            }
        }

        public void crearVino(string añada, DateTime fecha, string img, string nombre, string nota, int precio, List<Maridaje> maridajesParaNuevoVino, List<TipoUva> tipoUvasParaNuevoVino, List<string[]> varietales, Bodega b)
        {
            Vino nuevoVino = new Vino(añada, fecha, img, nombre, nota, precio, b);
            nuevoVino.Maridaje = maridajesParaNuevoVino;
            nuevoVino.crearVarietal(varietales, tipoUvasParaNuevoVino);

        }

        public void SetFechaActualizacion(DateTime fecha)
        {
            this.FechaUltimaActualizacion = fecha;
        }
    }
}
