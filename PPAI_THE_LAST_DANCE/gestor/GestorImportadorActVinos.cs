using PPAI_THE_LAST_DANCE.AccesoADatos;
using PPAI_THE_LAST_DANCE.boundary;
using PPAI_THE_LAST_DANCE.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.gestor
{
   
    public class GestorImportadorActVinos
    {
        private List<Bodega> bodegas { get; set; }
        private List<Vino> datosVinosImportados { get; set; }
        private string fechaHoraActual { get; set; }
        private List<TipoUva> tiposUva { get; set; }
        private pantImportadoraActVinos pantallaImportadoraActVinos;

        List<Bodega> listaBodegas = new List<Bodega>();
        Bodega bodegaSeleccionada;
        private List<Maridaje> maridajes;



        public GestorImportadorActVinos(pantImportadoraActVinos pantalla)
        {
            pantallaImportadoraActVinos = pantalla;

            Maridaje maridaje1 = new Maridaje("Queso y Vino Tinto", "Un clásico maridaje donde el queso añejo se complementa con un robusto vino tinto.");
            Maridaje maridaje2 = new Maridaje("Mariscos y Vino Blanco", "Los mariscos frescos se realzan con la acidez y frescura de un vino blanco.");
            Maridaje maridaje3 = new Maridaje("Carne Roja y Cabernet Sauvignon", "La carne roja y jugosa se equilibra con un Cabernet Sauvignon tánico.");
            Maridaje maridaje4 = new Maridaje("Pasta y Chianti", "La pasta con salsa de tomate combina perfectamente con la acidez del Chianti.");
            Maridaje maridaje5 = new Maridaje("Postres y Vino Dulce", "Los postres se acompañan idealmente con un vino dulce y afrutado.");
            Maridaje maridaje6 = new Maridaje("Sushi y Sake", "El sushi fresco y delicado se complementa con la suavidad del sake.");
            Maridaje maridaje7 = new Maridaje("Pollo y Chardonnay", "El pollo asado se realza con la complejidad y cuerpo de un Chardonnay.");
            Maridaje maridaje8 = new Maridaje("Pizza y Lambrusco", "La pizza, con su sabor versátil, se equilibra con la efervescencia de un Lambrusco.");
            Maridaje maridaje9 = new Maridaje("Ensalada y Sauvignon Blanc", "Las ensaladas frescas y ligeras se acompañan bien con un Sauvignon Blanc.");
            Maridaje maridaje10 = new Maridaje("Chocolate y Vino de Oporto", "El chocolate oscuro se intensifica con la riqueza y dulzura de un vino de Oporto.");
            this.maridajes = new List<Maridaje> { maridaje1, maridaje2, maridaje3, maridaje4, maridaje5, maridaje6, maridaje7, maridaje8, maridaje9, maridaje10 };
        }
        

        public void ActualizarFechaActualizacionBodega() { }
        public void ActualizarCrearVinos() { }
        public List<Bodega> BuscarBodegaActualizacionDisp() 
        {
           ADGestor ad_gestor = new ADGestor();
           DataTable tabla = new DataTable();
           tabla = ad_gestor.buscarBodegasConActualizacionDisp();

            

            foreach (DataRow row in tabla.Rows)
            {
                Bodega bodega = new Bodega();
                bodega.CoordenadasUbicacion = row["coordenadasUbicacion"].ToString();
                bodega.Descripcion = row["descripcion"].ToString();
                bodega.FechaUltimaActualizacion = row["fechaUltimaActualizacion"].ToString();
                bodega.Historia = row["historia"].ToString();
                bodega.Nombre = row["nombre"].ToString();
                bodega.PeriodoActualizacion = 2;//row["periodoActualizacion"];

                if (bodega.EsActualizable()) 
                {
                    listaBodegas.Add(bodega.GetDatos());

                }
            }
 
            return listaBodegas;
        }
        public List<Maridaje> BuscarMaridaje(List<String> m) 
        {
            List<Maridaje> maridajesss= new List<Maridaje>();

            foreach (String n in m)
            {
                foreach (Maridaje item in maridajes)
                {
                    if (item.SosMaridaje(n))
                    {
                        maridajesss.Add(item);
                    }
                }
            }
            return maridajesss;
            
        }
        public void BuscarSeguidoresBodega() { }
        public void CrearDTOvino() { }

        public  void crearVino(List<Maridaje> maridajes, List<TipoUva> tiposuva, DatosEntrantesSistemaBodega vino)
        {
            bodegaSeleccionada.crearVino(maridajes, tiposuva, vino);
        }
        public void CrearDatosVino(DatosEntrantesSistemaBodega vino )  
        {
            List<TipoUva> tiposuva = new List<TipoUva>();
            List<Maridaje> listaMaridajes = BuscarMaridaje(vino.Maridaje);
            //hacer lo mismo para los tiposuvas 
            crearVino(listaMaridajes, tiposuva, vino);
        }
        public void FinCU() { }
        public DateTime GetFechaHoraActual() => DateTime.Now;
        public void ObtenerActualizacionesBodega() 
        {
            List<Vino> v = new List<Vino>();

            InterfaceSistemaBodega interfazapi = new InterfaceSistemaBodega();

            List<DatosEntrantesSistemaBodega> listaS = interfazapi.ObtenerActualizacionesBodega();
            ObtenerVinosAActualizar(listaS);
        }
        public void OpcionImportarActualizacionVinos() 
        {
            this.bodegas = BuscarBodegaActualizacionDisp();
        }
        public void ObtenerVinosActualizados() { }
        public void TomarSeleccionBodega(string nombreBodega) 
        {
            foreach (Bodega bod in listaBodegas)
            {
                if (bod.Nombre == nombreBodega)
                {
                    this.bodegaSeleccionada = bod;
                }
            }
            ObtenerActualizacionesBodega();
        }

        public void ObtenerVinosAActualizar(List<DatosEntrantesSistemaBodega> listaS)
        {
            foreach (DatosEntrantesSistemaBodega vino in listaS)
            {
                if (bodegaSeleccionada.tenesEsteVino(vino))
                {
                    bodegaSeleccionada.ActualizarVino(vino);
                }
                else
                {
                    CrearDatosVino(vino);
                }
            }
        }
    }

}
