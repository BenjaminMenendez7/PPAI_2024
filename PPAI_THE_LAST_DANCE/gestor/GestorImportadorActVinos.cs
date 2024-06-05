
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

            Bodega bodega1 = new Bodega("40.712776 58.987987",
                "Bodega principal en Nueva York",
                "2024/05/05",
                "Fundada en 1901, esta bodega ha sido un pilar en la industria de Nueva York.",
                "Bodega Central NY", 1);

            Bodega bodega2 = new Bodega("34.052235, -118.243683",
                "Bodega en Los Ángeles",
                "2024/10/23",
                "Establecida en 1920, ha servido a la comunidad local con productos frescos.",
                "Bodega LA", 2);

            Bodega bodega3 = new Bodega(
                "51.507351, -0.127758",
                "Bodega en Londres",
                "2023/01/22",
                "Con una rica historia desde 1850, esta bodega es conocida por sus vinos exclusivos.",
                "Bodega Londres", 11);

            Bodega bodega4 = new Bodega(
                "-33.868820, 151.209290",
                "Bodega en Sídney",
                "2024/12/02",
                "Inaugurada en 1950, esta bodega se destaca por sus innovaciones tecnológicas.",
                "Bodega Sídney", 3);

            Bodega bodega5 = new Bodega(
                "35.689487, 139.691711",
                "Bodega en Tokio",
                "2022/02/02",
                "Desde 1965, la bodega de Tokio ofrece productos gourmet de alta calidad.",
                "Bodega Tokio", 8);



            this.bodegas = new List<Bodega> { bodega1, bodega2, bodega3, bodega4, bodega5};

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


            TipoUva tipoUva1 = new TipoUva("Variedad de uva roja con un sabor suave y afrutado.", "Merlot");
            TipoUva tipoUva2 = new TipoUva("Uva blanca conocida por su sabor fresco y cítrico.", "Chardonnay");
            TipoUva tipoUva3 = new TipoUva("Uva roja con un sabor intenso y un toque de especias.", "Cabernet Sauvignon");
            TipoUva tipoUva4 = new TipoUva("Variedad de uva blanca con un sabor floral y a frutas tropicales.", "Sauvignon Blanc");
            TipoUva tipoUva5 = new TipoUva("Uva roja famosa por su suavidad y sabor a frutas del bosque.", "Pinot Noir");
            TipoUva tipoUva6 = new TipoUva("Variedad de uva blanca con un sabor dulce y a melón.", "Riesling");
            TipoUva tipoUva7 = new TipoUva("Uva roja con un sabor robusto y a frutos secos.", "Syrah");
            TipoUva tipoUva8 = new TipoUva("Variedad de uva blanca con un sabor a manzana y peras.", "Pinot Grigio");
            TipoUva tipoUva9 = new TipoUva("Uva roja con un sabor fuerte y a especias.", "Zinfandel");
            TipoUva tipoUva10 = new TipoUva("Variedad de uva blanca con un sabor refrescante y cítrico.", "Gewürztraminer");

            this.tiposUva = new List<TipoUva> { tipoUva1, tipoUva2, tipoUva3, tipoUva4, tipoUva5, tipoUva6, tipoUva7, tipoUva8, tipoUva9, tipoUva10 };

        }



        public void ActualizarFechaActualizacionBodega() 
        {
            bodegaSeleccionada.SetFechaActualizacion();
        }
        public void ActualizarCrearVinos() { }
        public List<Bodega> BuscarBodegaActualizacionDisp()
        {
            List<Bodega> bodegasActualizables = new List<Bodega>();
            foreach (Bodega b in bodegas)
            {
                if (b.EsActualizable())
                {
                    bodegasActualizables.Add(b);
                }
            }
            return bodegasActualizables;
        }
        public List<Maridaje> BuscarMaridaje(List<String> m)
        {
            List<Maridaje> maridajesss = new List<Maridaje>();

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

        public List<TipoUva> BuscarTipoUva(List<String> u)
        {
            List<TipoUva> tipouvass = new List<TipoUva>();

            foreach (String n in u)
            {
                foreach (TipoUva item in tiposUva)
                {
                    if (item.SosTipoUva(n))
                    {
                        tipouvass.Add(item);
                    }
                }
            }
            return tipouvass;
        }
        public void BuscarSeguidoresBodega() { }
        public void CrearDTOvino() { }

        public void crearVino(List<Maridaje> maridajes, List<TipoUva> tiposuva, DatosEntrantesSistemaBodega vino)
        {
            bodegaSeleccionada.crearVino(maridajes, tiposuva, vino);
        }
        public void CrearDatosVino(DatosEntrantesSistemaBodega vino)
        {
            List<DatosEntrantesVarietales> vvv = vino.Varietal;
            List<String> tpu = new List<String>();
            foreach (DatosEntrantesVarietales item in vvv)
            {
                String tipo = item.TipoUva;
                tpu.Add(tipo);
            }
            List<TipoUva> listatiposuva = BuscarTipoUva(tpu);  
            
            List<Maridaje> listaMaridajes = BuscarMaridaje(vino.Maridaje);

            DateTime fechaActual = DateTime.Now;
 
            crearVino(listaMaridajes, listatiposuva, vino);
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
