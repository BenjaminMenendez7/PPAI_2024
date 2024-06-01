﻿using PPAI_THE_LAST_DANCE.gestor;
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



            //grillaBodegas.Rows.Add(bodega1.GetNombre(), bodega1.GetDescripcion(), bodega1.GetFecha());
            //grillaBodegas.Rows.Add(bodega2.GetNombre(), bodega2.GetDescripcion(), bodega2.GetFecha());
            //grillaBodegas.Rows.Add(bodega3.GetNombre(), bodega3.GetDescripcion(), bodega3.GetFecha());
            //grillaBodegas.Rows.Add(bodega4.GetNombre(), bodega4.GetDescripcion(), bodega4.GetFecha());
            //grillaBodegas.Rows.Add(bodega5.GetNombre(), bodega5.GetDescripcion(), bodega5.GetFecha());



        }
        public void MostrarResumenVinosImportados() { }

        public void SolicitarSeleccionBodega() { }
        public void TomarSeleccionBodega()
        {
            //este es el metodo que es desencadenado por el boton actualizar


            // pasar los datos de la bodega seleccionada por el usuario
            //List<Bodega> bs = new List<Bodega>();
            //Bodega bodsec = new Bodega();
            //List<Vino> vinoo = new List<Vino>();
            //DateTime fech = new DateTime();
            //List<TipoUva> tps = new List<TipoUva>();

            //GestorImportadorActVinos gestor = new GestorImportadorActVinos(bs, bodsec, vinoo, fech, tps);
            //gestor.TomarSeleccionBodega();
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
        }
    }
}