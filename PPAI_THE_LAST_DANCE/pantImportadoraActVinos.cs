using PPAI_THE_LAST_DANCE.entity;
using PPAI_THE_LAST_DANCE.gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        public void MostrarBodegas(List<string> bodegas)
        {

            if ((bodegas.Count == 0))
            {
                MessageBox.Show("No hay bodegas con actualizaciones disponibles.");
            }
            else
            {
                for (int i = 0; i < bodegas.Count; i++)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    DataGridViewCell nombreBodega = new DataGridViewTextBoxCell();
                    nombreBodega.Value = bodegas[i];

                    fila.Cells.Add(nombreBodega);
                    grillaBodegas.Rows.Add(fila);
                    
                    // Establecer el modo de selección en FullRowSelect para seleccionar filas completas
                    grillaBodegas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Desactivar la edición de celdas
                    grillaBodegas.ReadOnly = true;

                }

            }
            // alert para que el adm de bomvino eliga una bodega (click en fila de grilla)
            this.SolicitarSeleccionBodega();
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
        public void MostrarResumenVinosImportados(string bSeleccionada, List<Vino> vinos) 
        {
            grillaBodegas.Visible = true;
            if (vinos.Count == 0)
            {
                MessageBox.Show("No hay resumen para la bodega :" + bSeleccionada);
            }
            else
            {
                foreach (var objeto in vinos)
                {

                    DataGridViewRow fila = new DataGridViewRow();

                    DataGridViewCell nombreVino = new DataGridViewTextBoxCell();
                    nombreVino.Value = objeto.Nombre;

                    DataGridViewCell FechaActulizacion = new DataGridViewTextBoxCell();
                    FechaActulizacion.Value = objeto.BodegaActualizacion.ToShortDateString();

                    DataGridViewCell añadaVino = new DataGridViewTextBoxCell();
                    añadaVino.Value = objeto.Anada;

                    DataGridViewCell precioVino = new DataGridViewTextBoxCell();
                    precioVino.Value = objeto.PrecioARS;


                    fila.Cells.Add(nombreVino);
                    fila.Cells.Add(FechaActulizacion);
                    fila.Cells.Add(añadaVino);
                    fila.Cells.Add(precioVino);

                    grillaVinos.Rows.Add(fila);
                    // Establecer el modo de selección en FullRowSelect para seleccionar filas completas
                    grillaVinos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Desactivar la edición de celdas
                    grillaVinos.ReadOnly = true;
                }
                //label4.Text = label4.Text + bSeleccionada;
                grillaBodegas.Enabled = false;

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
                labelSelec1.Text = nombreBod;
                labelSelec2.Text = nombreBod;
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

        private void grillaBodegas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void nuevaSelecc_Click_1(object sender, EventArgs e)
        {
            // Limpiar la selección del DataGridView de Bodegas 
            if (grillaBodegas != null)
            {
                grillaBodegas.ClearSelection();
                grillaBodegas.Enabled = true;

                // Limpiar el contenido del DataGridView de vinos
                grillaVinos.Rows.Clear();
                grillaVinos.Visible = false;

            }
            MessageBox.Show("Se ha limpiado la selección de la bodega y el contenido de sus de vinos.");


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
             
            grillaVinos.Rows.Clear();
            
            grillaBodegas.Enabled = true;
            grillaVinos.Visible= true;
            
           MessageBox.Show("Se ha limpiado la seleccion de la bodega y el contenido de sus vinos");
            

        }
    }
}
