using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.entity
{
    public class Bodega
    {
        private string coordenadasUbicacion;
        private string descripcion;
        private string fechaUltimaActualizacion;
        private string historia;
        private string nombre;
        private int periodoActualizacion;
        private List<Vino> vinos = new List<Vino>();

        public Bodega(string coordenadasUbicacion, string descripcion, string fechaUltimaActualizacion, string historia, string nombre, int periodoActualizacion, List<Vino> vinos)
        {
            this.coordenadasUbicacion = coordenadasUbicacion;
            this.descripcion = descripcion;
            this.fechaUltimaActualizacion = fechaUltimaActualizacion;
            this.historia = historia;
            this.nombre = nombre;
            this.periodoActualizacion = periodoActualizacion;
            this.vinos = vinos;
        }

        public string CoordenadasUbicacion { get => coordenadasUbicacion; set => coordenadasUbicacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string FechaUltimaActualizacion { get => fechaUltimaActualizacion; set => fechaUltimaActualizacion = value; }
        public string Historia { get => historia; set => historia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PeriodoActualizacion { get => periodoActualizacion; set => periodoActualizacion = value; }
        public List<Vino> Vinos { get => vinos; set => vinos = value; }


        public bool EsActualizable()
        {
            if (ValidarFechaActual())
            {
                return true;
            }
            else
                return false;
        }

        private bool ValidarFechaActual()
        {
            DateTime fecha = DateTime.ParseExact(FechaUltimaActualizacion, "yyyy/MM/dd", null);
            DateTime fechaNueva = fecha.AddMonths(PeriodoActualizacion);

            if (fechaNueva <= DateTime.Now)
            {
                return true;
            }
            else
                return false;

        }

        public Boolean tenesEsteVino(DatosEntrantesSistemaBodega vino)
        {
            foreach (Vino v in vinos)
            {
                if (v.sosDeBodega(vino))
                {
                    return true;
                }

            }
            return false;
        }

        public void ActualizarVino(DatosEntrantesSistemaBodega vino)
        {
            foreach (Vino v in vinos)
            {
                if (v.sosDeBodega(vino))
                {
                    v.SetPrecio(vino.PrecioARS);
                    v.SetNotaCata(vino.NotaDeCataBodega);
                    v.SetImagenEtiqueta(vino.ImagenEtiqueta);
                    v.SetFechaActualizacion(DateTime.Now);
                }
            }
        }

        public void crearVino(List<Maridaje> maridajes, List<TipoUva> tiposuva, DatosEntrantesSistemaBodega vino)
        {
            Vino newVino = new Vino();
            this.vinos.Add(newVino.crearVino(maridajes, tiposuva, vino));  
        }

        public void SetFechaActualizacion()
        {
            this.fechaUltimaActualizacion = DateTime.Now.ToString();
        }
    }
}
