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

        //PASO1
        public void OpcionImportarActualizacionVinos()
        {
            HabilitarVentana();
        }

        public void HabilitarVentana()
        {
            this.ShowDialog();
        }

        private void pantImportadoraActVinos_Load(object sender, EventArgs e)
        {
            this.gestor.OpcionImportarActualizacionVinos();
        }

        public void MostrarBodegas(List<Bodega> bod)
        {

            foreach (Bodega bodega in bod)
            {
                grillaBodegas.Rows.Add(bodega.Nombre, bodega.Descripcion, bodega.FechaUltimaActualizacion, bodega.PeriodoActualizacion);
            }

            SolicitarSeleccionBodega();
        }

        public void SolicitarSeleccionBodega()
        {
            btnActualizar.Enabled = true;
        }

        public void TomarSeleccionBodega(DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                DataGridViewRow filaSeleccionada = grillaBodegas.Rows[indice];
                string nombreBod = filaSeleccionada.Cells["nombre"].Value.ToString();
                gestor.TomarSeleccionBodega(nombreBod);
            }
        }
        public void MostrarResumenVinosImportados(Bodega bod) 
        {
            foreach (Vino vino in bod.Vinos)
            {
                grillaVinos.Rows.Add(vino.Nombre, vino.Anada, vino.PrecioARS, vino.NotaDeCataBodega);
            }
        }

        ///  -------------------------------------------------------------------------------

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
           
            DataGridViewCellEventArgs eventArgs = new DataGridViewCellEventArgs(grillaBodegas.CurrentCell.ColumnIndex, grillaBodegas.CurrentCell.RowIndex);
            TomarSeleccionBodega(eventArgs);
        }

        private void grillaVinos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
