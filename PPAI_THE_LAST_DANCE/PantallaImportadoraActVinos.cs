using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using PPAI_THE_LAST_DANCE.entity;
using PPAI_THE_LAST_DANCE.gestor;

namespace PPAI_THE_LAST_DANCE
{
    public partial class PantallaImportadoraActVinos : Form
    {
        public PantallaImportadoraActVinos()
        {
            InitializeComponent();
           

        }

        public void GrillaVinosImportados() { }
        public void LabelBodegaSeleccionada() { }
        public void LabelVinosImportados() { }
        public void ListaBodegasParaSeleccion() { }

        public void MostrarBodegas()
        {
            Bodega bodega1 = new Bodega(
                 "40.712776, -74.005974",
                 "Bodega principal en Nueva York",
                 new DateTime(2023, 04, 30),
                 "Fundada en 1901, esta bodega ha sido un pilar en la industria de Nueva York.",
                 "Bodega Central NY",
                 1
                 );

            Bodega bodega2 = new Bodega(
                "34.052235, -118.243683",
                "Bodega en Los Ángeles",
                new DateTime(2024, 05, 17),
                "Establecida en 1920, ha servido a la comunidad local con productos frescos.",
                "Bodega LA",
                2
                );

            Bodega bodega3 = new Bodega(
                "51.507351, -0.127758",
                "Bodega en Londres",
                new DateTime(2023, 07, 13),
                "Con una rica historia desde 1850, esta bodega es conocida por sus vinos exclusivos.",
                "Bodega Londres",
                11
                );

            Bodega bodega4 = new Bodega(
                "-33.868820, 151.209290",
                "Bodega en Sídney",
                new DateTime(2024, 01, 05),
                "Inaugurada en 1950, esta bodega se destaca por sus innovaciones tecnológicas.",
                "Bodega Sídney",
                3
                );

            Bodega bodega5 = new Bodega(
                "35.689487, 139.691711",
                "Bodega en Tokio",
                new DateTime(2023, 12, 28),
                "Desde 1965, la bodega de Tokio ofrece productos gourmet de alta calidad.",
                "Bodega Tokio",
                8
                );
            

            grillaBodegas.Rows.Add(bodega1.GetNombre(), bodega1.GetDescripcion(), bodega1.GetFecha());
            grillaBodegas.Rows.Add(bodega2.GetNombre(), bodega2.GetDescripcion(), bodega2.GetFecha());
            grillaBodegas.Rows.Add(bodega3.GetNombre(), bodega3.GetDescripcion(), bodega3.GetFecha());
            grillaBodegas.Rows.Add(bodega4.GetNombre(), bodega4.GetDescripcion(), bodega4.GetFecha());
            grillaBodegas.Rows.Add(bodega5.GetNombre(), bodega5.GetDescripcion(), bodega5.GetFecha());

            
            
        }
        public void MostrarResumenVinosImportados() { }
        public void OpcionImportarActualizacionVinos() { }
        public void SolicitarSeleccionBodega() { }
        public void TomarSeleccionBodega() 
        {
            // pasar los datos de la bodega 
            List<Bodega> bs = new List<Bodega>();
            Bodega bodsec = new Bodega();
            List<Vino> vinoo = new List<Vino>();
            DateTime fech = new DateTime();
            List<TipoUva> tps = new List<TipoUva>();

            GestorImportadorActVinos gestor = new GestorImportadorActVinos(bs, bodsec, vinoo, fech, tps);
            gestor.TomarSeleccionBodega();
        }

        private void HabilitarVentana(object sender, EventArgs e)
        {
           MostrarBodegas();
        }

        private void grillaBodegas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                
                DataGridViewRow filaSeleccionada = grillaBodegas.Rows[indice];
                string nombreBod = filaSeleccionada.Cells["nombre"].Value.ToString();

                labelSelec.Text = nombreBod;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
          TomarSeleccionBodega();
        }
    }
}
