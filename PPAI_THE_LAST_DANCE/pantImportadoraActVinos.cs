using PPAI_THE_LAST_DANCE.entity;
using PPAI_THE_LAST_DANCE.gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_THE_LAST_DANCE
{
    public partial class pantImportadoraActVinos : Form
    {

        private GestorImportadorActVinos gestor;        // Dentro de la clase pantalla se agrega un puntero al gestor

        public GestorImportadorActVinos Gestor { get => gestor; set => gestor = value; }
        public pantImportadoraActVinos()
        {
            InitializeComponent();
            gestor = new GestorImportadorActVinos(this);
        }

        public void OpcionImportarActualizacionVinos()
        {
            HabilitarVentana();
        }

        public void HabilitarVentana()
        {
            this.ShowDialog();
        }

        public void GrillaVinosImportados() { }
        public void LabelBodegaSeleccionada() { }
        public void LabelVinosImportados() { }
        public void ListaBodegasParaSeleccion() { }

        public void MostrarBodegas()
        {
            List<Bodega> bodegas = gestor.BuscarBodegaActualizacionDisp();

            foreach (Bodega bodega in bodegas)
            {
                grillaBodegas.Rows.Add(bodega.Nombre, bodega.Descripcion, bodega.FechaUltimaActualizacion);
            }

            SolicitarSeleccionBodega();


        }
        public void MostrarResumenVinosImportados() { }

        public void SolicitarSeleccionBodega()
        {
            btnActualizar.Enabled = true;
        }
        public void TomarSeleccionBodega()
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {

                DataGridViewRow filaSeleccionada = grillaBodegas.Rows[indice];
                string nombreBod = filaSeleccionada.Cells["nombre"].Value.ToString();

                gestor.TomarSeleccionBodega(nombreBod);

            }
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

        private void pantImportadoraActVinos_Load(object sender, EventArgs e)
        {
            this.gestor.OpcionImportarActualizacionVinos();
            MostrarBodegas();
        }
    }
}
