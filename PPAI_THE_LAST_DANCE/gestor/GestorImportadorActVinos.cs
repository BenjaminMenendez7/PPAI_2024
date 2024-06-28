
using PPAI_THE_LAST_DANCE.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_THE_LAST_DANCE.gestor
{

    public class GestorImportadorActVinos
    {

        private pantImportadoraActVinos pantalla;

        Bodega bodegaSeleccionada;

        private List<Bodega> bodegas;
        private List<Enofilo> enofilosSeguidores;

        private List<DatosEntrantesSistemaBodega> vinosImportados { get; set; }
        private List<DatosEntrantesSistemaBodega> vinosParaActualizar;

        private List<Maridaje> maridajes;
        private List<TipoUva> tiposUva { get; set; }

        private InterfaceSistemaBodega InterfaceSistemaBodega;

        public GestorImportadorActVinos(pantImportadoraActVinos pantalla)
        {
            this.pantalla = pantalla;
            
            this.bodegas = new List<Bodega>();
            this.tiposUva = new List<TipoUva>();
            this.vinosImportados = new List<DatosEntrantesSistemaBodega>();
            this.vinosParaActualizar = new List<DatosEntrantesSistemaBodega>();
            this.maridajes = new List<Maridaje>();
            this.enofilosSeguidores = new List<Enofilo>();

            
            this.load();

        }

        private void load()
        { 
            Random random = new Random();

            List<Vino> vinosDelSistema = new List<Vino>();

            string[] variedadesTintas = new string[]
            {
                "Merlot",
                "Syrah",
                "Cabernet Sauvignon",
                "Pinot Noir",
                "Malbec",
                "Tempranillo",
                "Zinfandel",
                "Grenache",
                "Nebbiolo",
                "Sangiovese",
                "Barbera",
            };
            string[] variedadesBlancas = new string[]
            {
                "Verdejo",
                "Godello",
                "Chardonnay",
                "Sauvignon Blanc",
                "Riesling",
                "Pinot Grigio",
                "Chenin Blanc",
                "Gewürztraminer",
                "Viognier",
                "Albariño"
            };
            string[] maridajeDescripciones = new string[]
            {
                "Realza las características de los platos",
                "Combina a la perfección con carnes rojas",
                "Ideal para acompañar platos de pescado",
                "Equilibra los sabores de platos agridulces",
                "Perfecto para maridar con quesos fuertes",
                "Excelente con pastas en salsas cremosas",
                "Complementa bien con ensaladas frescas",
                "Realza los sabores de platos picantes",
                "Marida perfectamente con mariscos",
                "Ideal para acompañar aves de corral",
                "Combina bien con platos vegetarianos",
                "Equilibra los sabores de platos grasos",
                "Perfecto para acompañar sushi",
                "Excelente con postres de chocolate",
                "Marida bien con platos de cerdo",
                "Ideal para acompañar tapas y aperitivos",
                "Realza los sabores de comidas mediterráneas",
                "Combina bien con platos ahumados",
                "Perfecto para acompañar guisos y estofados",
                "Marida bien con pizzas y platos italianos"
            };
            string[] nombres =
            {
              "Juan", "Carlos", "Martín", "Pedro", "Lucas",
                "Javier", "Miguel", "Diego", "Gonzalo", "Agustín",
                "María", "Laura", "Ana", "Sofía", "Valentina",
                "Elena", "Camila", "Julieta", "Abril", "Florencia"
            };
            string[] apellidos = new string[]
            {
                "García", "Martínez", "Rodríguez", "López", "González", "Hernández", "Pérez", "Sánchez", "Ramírez", "Torres",
                "Flores", "Rivera", "Gómez", "Diaz", "Cruz", "Reyes", "Morales", "Ortiz", "Gutiérrez", "Chávez",
                "Ramos", "Romero", "Vargas", "Ruiz", "Castillo", "Fernández", "Jiménez", "Mendoza", "Iglesias", "Silva",
                "Soto", "Delgado", "Ortiz", "Ramos", "Guerrero", "Molina", "Castro", "Suárez", "Domínguez", "Alvarez",
                "Vega", "Paredes", "Rojas", "Campos", "Mejía", "Herrera", "Aguilar", "Santos", "Montes", "Peña"
            };
            string[] nombresVinosPopulares = new string[]
            {
                "Malbec Reserva",
                "Chardonnay Gran Reserva",
                "Cabernet Sauvignon",
                "Merlot Clásico",
                "Sauvignon Blanc Premium",
                "Syrah Vendimia Seleccionada",
                "Pinot Noir Joven",
                "Tannat Roble",
                "Rosé Brut Nature",
                "Torrontés Dulce",
                "Riesling Seco",
                "Tempranillo Crianza",
                "Zinfandel Old Vine",
                "Grenache Blanc",
                "Viognier Prestige",
                "Petite Sirah Reserva",
                "Carmenere Especial",
                "Garnacha Joven",
                "Verdejo Superior",
                "Barbera d'Asti",
                "Nebbiolo Langhe",
                "Sangiovese Classico",
                "Albariño Rías Baixas",
                "Grüner Veltliner",
                "Cava Brut Reserva",
                "Champagne Brut Rosé",
                "Prosecco Superiore",
                "Moscato d'Asti",
                "Chianti Riserva",
                "Pinot Grigio delle Venezie"
            };
            string[] nombreBodegas = new string[]
            {
                "Catena Zapata",
                "Bodega Norton",
                "Trapiche",
                "Bodegas Salentein",
                "Bodega Luigi Bosca",
                "Bodega El Esteco",
                "Bodega Colomé",
                "Bodega Zuccardi",
                "Bodega La Rural",
                "Bodega Vistalba",
                "Bodega Familia Schroeder",

            };

            // Tipos de Uva del sistema

            for (int i = 1; i <= variedadesTintas.Length; i++)
            {
                string nombre = variedadesTintas[i - 1];
                string descripcion = "Descripcion uva(Tinta) :" + nombre;
                TipoUva tip = new TipoUva(descripcion, nombre);
                this.tiposUva.Add(tip);
            }
            for (int i = 1; i < variedadesBlancas.Length; i++)
            {
                string nombre = variedadesBlancas[i - 1];
                string descripcion = "Descripción uva(Blanca): " + nombre;
                TipoUva tip = new TipoUva(descripcion, nombre);
                this.tiposUva.Add(tip);
            }

            // Maridajes del sistema
            for (int i = 1; i <= maridajeDescripciones.Length; i++)
            {
                string descripcion = maridajeDescripciones[i - 1];
                string nombre = "Maridaje" + (i - 1);
                Maridaje maridaje = new Maridaje(descripcion, nombre);
                this.maridajes.Add(maridaje);
            }

            // Bodegas del sistema
            for (int b = 1; b <= (nombreBodegas.Length); b++)
            {
                // nombre
                string nombreBodega = nombreBodegas[b - 1];

                // fechaUltimaActualizacion random
                int año = random.Next(2023, 2025);
                int mes = random.Next(1, 13);
                int dia = random.Next(1, DateTime.DaysInMonth(año, mes));
                DateTime fechaUltimaActualizacion = new DateTime(año, mes, dia);

                // periodo de actualizacion
                int periodo = random.Next(1, 13);

                // Crear instancia de Bodega con los datos generados
                Bodega bodega = new Bodega(nombreBodega, "descripcion" + b, fechaUltimaActualizacion, periodo, "historia de la bodega" + b);
                // Agregar la bodega a la lista de bodegas
                this.bodegas.Add(bodega);
            }

            //Vinos

            for (int i = 1; i <= (nombresVinosPopulares.Count() - 1); i++)
            {
                // Generar datos para el vino
                int añoAñada = random.Next(1950, 2025);

                int añoFAleatoria = random.Next(2022, 2025);
                int mesFAleatoria = random.Next(1, 7);
                int diaFAleatoria = random.Next(1, DateTime.DaysInMonth(añoFAleatoria, mesFAleatoria));
                DateTime fechaActualizacion = new DateTime(añoFAleatoria, mesFAleatoria, diaFAleatoria);

                int precioAleatorio = random.Next(1000, 100001);

                string notaDeCata = "";

                // Maridajes
                List<Maridaje> maridajeVino = new List<Maridaje>();
                int nroM = random.Next(1, 6);
                for (int z = 0; z < nroM; z++)
                {
                    maridajeVino.Add(this.maridajes[random.Next(nroM)]);
                }

                // Varietales
                List<Varietal> varietalesVino = new List<Varietal>();
                int nroV = random.Next(1, 6); // nro al azar entre 1 y 5, pq tengo 5 tiposUva en el sistema
                for (int z = 0; z < nroV; z++)
                {
                    string nombreVarietal = $"Varietal : {z}";
                    string descripcionVarietal = $"Vino varietal con predominancia de una variedad de uva";
                    int porcentajeComposicion = random.Next(80, 101); // Entre 80% y 100%
                    Varietal v = new Varietal(nombreVarietal, descripcionVarietal, porcentajeComposicion, this.tiposUva[random.Next(nroV)]);
                    varietalesVino.Add(v);
                }

                //Bodega para el vino
                var indiceAleatorio = random.Next(0, this.bodegas.Count());
                var bodegaAleatoria = this.bodegas[indiceAleatorio];

                // Crear instancia de Vino con los datos generados
                string nombreVino = nombresVinosPopulares[i - 1];
                string linkImg = "https://picsum.photos/" + i;

                Vino vino = new Vino(añoAñada.ToString(), fechaActualizacion, linkImg, nombreVino, notaDeCata, precioAleatorio, bodegaAleatoria);
                vino.Maridaje = maridajeVino;
                vino.Varietales = varietalesVino;

                // se carga a la bodega el vino en cuestion
                bodegaAleatoria.Vinos.Add(vino);
                vinosDelSistema.Add(vino);
                //this.vinosDelSistema.Add(vino);
            }
            // Enofilos del sistema

            for (int i = 1; i <= 20; i++)
            {
                string nombreEnofilo = nombres[random.Next(nombres.Length)];
                string apellidoEnofilo = apellidos[random.Next(apellidos.Length)];
                string linkImgPerfil = "https://example.com/images/" + i;
                string password = "password" + i;
                bool activo = i % 2 == 0; // Alternar entre true y false

                Usuario usuario = new Usuario(password, nombreEnofilo, activo);
                Enofilo enofilo = new Enofilo(apellidoEnofilo, linkImgPerfil, nombreEnofilo, usuario);

                // Vinos favoritos del Enofilo
                for (int j = 0; j <= random.Next(vinosDelSistema.Count); j++)
                {
                    if (enofilo.Favorito == null)
                    {
                        enofilo.Favorito = new List<Vino>();
                    }
                    enofilo.Favorito.Add(vinosDelSistema[j]);
                }

                // Seguidos del enofilo y cada seguido conoce una bodega o un enofilo
                List<Siguiendo> seguidos = new List<Siguiendo>();

                int cantidadSeguidos = random.Next(1, 10);
                for (int k = 1; k <= cantidadSeguidos; k++)
                {
                    DateTime fechaInicio = DateTime.Now.AddDays(random.Next(1, 365));
                    DateTime fechaFin = DateTime.Now.AddDays(random.Next(1, 365));

                    Siguiendo siguiendo = new Siguiendo(fechaInicio, fechaFin);

                    if (random.Next(2) == 0) // 50% probabilidad de seguir una bodega
                    {
                        siguiendo.Bodega = this.bodegas[random.Next(this.bodegas.Count)];
                    }
                    else // 50% probabilidad de seguir un enófilo
                    {
                        if (this.enofilosSeguidores.Count > 0)
                        {
                            siguiendo.Enofilo = this.enofilosSeguidores[random.Next(this.enofilosSeguidores.Count)];
                        }
                        else { siguiendo.Bodega = this.bodegas[random.Next(this.bodegas.Count)]; }

                    }
                    seguidos.Add(siguiendo);
                }
                enofilo.Seguido = seguidos;
                this.enofilosSeguidores.Add(enofilo);
            }
        }

        public void OpcionImportarActualizacionVinos()
        {
            List<string> bodegasConActualizacion = new List<string>();
            bodegasConActualizacion = BuscarBodegaActualizacionDisp();

            pantalla.MostrarBodegas(bodegasConActualizacion);
        }

        public List<string> BuscarBodegaActualizacionDisp()
        {
            List<string> bodegasParaActualizar = new List<string>();

            DateTime fechaActual = this.getFechaActual();

            foreach (Bodega bodega in this.bodegas)
            {
                if (bodega.EsActualizable(fechaActual))
                {
                    bodegasParaActualizar.Add(bodega.Nombre);
                }
            }
            return bodegasParaActualizar;

        }
        public DateTime getFechaActual() {return DateTime.Now.Date;}

        public void TomarSeleccionBodega(string nombreBodega)
        {
            foreach (Bodega b in this.bodegas)
            {
                if (b.Nombre == nombreBodega)
                {
                    this.bodegaSeleccionada = b;
                }
            }
            ObtenerActualizacionesBodega(this.bodegaSeleccionada.Nombre);
        }

        public void ObtenerActualizacionesBodega(string nombreBodega)
        {
            this.InterfaceSistemaBodega = new InterfaceSistemaBodega(nombreBodega);
            this.vinosImportados = this.InterfaceSistemaBodega.ObtenerActualizacionesBodega(nombreBodega);
            this.ObtenerVinosAActualizar();
        }

        public void ObtenerVinosAActualizar() 
        {
            foreach (var v in this.vinosImportados)
            {
                string nombreVinoImportado = v.Nombre;
                if (bodegaSeleccionada.tenesEsteVino(nombreVinoImportado))
                {
                    this.vinosParaActualizar.Add(v);
                }
            }

            foreach (var v in this.vinosImportados)
            {

                if (vinosParaActualizar.Contains(v))
                {
                    this.actualizarVino(v);
                }
                else 
                {
                    this.CrearDatosVino(v);
                }
            }
            this.ActualizarFechaActualizacionBodega();
            this.pantalla.MostrarResumenVinosImportados(this.bodegaSeleccionada.Nombre, this.bodegaSeleccionada.Vinos);
            this.BuscarSeguidoresBodega();
            this.FinCU();

        }

        public void actualizarVino(DatosEntrantesSistemaBodega vinoAActualizar)
        {

            DateTime fecha = vinoAActualizar.FechaActualizacion;
            string img = vinoAActualizar.ImagenEtiqueta;
            string nombre = vinoAActualizar.Nombre;
            string nota = vinoAActualizar.NotaDeCataBodega;
            int precio = vinoAActualizar.PrecioARS;
            this.bodegaSeleccionada.ActualizarVino(nombre, precio, nota, img, fecha);
        }

        public void CrearDatosVino(DatosEntrantesSistemaBodega nuevoVino)
        {
            // validar si el vino importado tiene ALGUN maridaje
            List<Maridaje> maridajesParaNuevoVino = new List<Maridaje>();
            if (nuevoVino.Maridaje.Count > 0)
            {
                maridajesParaNuevoVino = this.BuscarMaridaje(nuevoVino.Maridaje);
            }

            //validar  si el vino tiene ALGUN tipo de uva
            List<TipoUva> tipoUvasParaNuevoVino = new List<TipoUva>();
            if (nuevoVino.Varietal.Count > 0)
            {
                tipoUvasParaNuevoVino = this.BuscarTipoUva(nuevoVino.Varietal);
            }
            string añada = nuevoVino.Añada;
            string img = nuevoVino.ImagenEtiqueta;
            DateTime fecha = nuevoVino.FechaActualizacion;
            string nombre = nuevoVino.Nombre;
            string nota = nuevoVino.NotaDeCataBodega;
            int precio = nuevoVino.PrecioARS;
            Bodega bodega = this.bodegaSeleccionada;
            bodegaSeleccionada.crearVino(añada, fecha, img, nombre, nota, precio, maridajesParaNuevoVino, tipoUvasParaNuevoVino, nuevoVino.Varietal, bodega);
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

        public List<TipoUva> BuscarTipoUva(List<string[
            ]> varietalesNuevoVino)
        {
            List<TipoUva> tiposUvaUtil = new List<TipoUva>();

            foreach (string[] varietal in varietalesNuevoVino)
            {
                for (int i = 1; i < this.tiposUva.Count; i++)
                {
                    if (this.tiposUva[i - 1].SosTipoUva(varietal[3]))
                    {
                        tiposUvaUtil.Add(tiposUva[i - 1]);
                    }
                }
            }
            return tiposUvaUtil;
        }

       

        public void ActualizarFechaActualizacionBodega() 
        {
            this.bodegaSeleccionada.SetFechaActualizacion(this.getFechaActual());

        }
        
        public void BuscarSeguidoresBodega() {
            List<string> strings = new List<string>();
            foreach (Enofilo enofilo in this.enofilosSeguidores)
            {
                String dato = enofilo.sosSeguidorBodega(bodegaSeleccionada);
                if (dato != null)
                {
                    strings.Add(dato);
                }
            }
            InterfaceNotificacion.enviarNotificacion(strings);
        }
  
        public void FinCU() 
        {
        }       
    }
}
