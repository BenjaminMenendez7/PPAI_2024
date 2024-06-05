namespace PPAI_THE_LAST_DANCE
{
    partial class pantImportadoraActVinos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.labelSelec = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grillaBodegas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaVinos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVinos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bodega seleccionada:";
            // 
            // labelSelec
            // 
            this.labelSelec.AutoSize = true;
            this.labelSelec.Location = new System.Drawing.Point(415, 367);
            this.labelSelec.Name = "labelSelec";
            this.labelSelec.Size = new System.Drawing.Size(0, 13);
            this.labelSelec.TabIndex = 6;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(552, 362);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grillaBodegas
            // 
            this.grillaBodegas.AllowUserToAddRows = false;
            this.grillaBodegas.AllowUserToDeleteRows = false;
            this.grillaBodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaBodegas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.fecha,
            this.periodoAct});
            this.grillaBodegas.Location = new System.Drawing.Point(174, 66);
            this.grillaBodegas.Name = "grillaBodegas";
            this.grillaBodegas.Size = new System.Drawing.Size(441, 267);
            this.grillaBodegas.TabIndex = 4;
            this.grillaBodegas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaBodegas_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "nombre";
            this.Nombre.MinimumWidth = 50;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "descripcion";
            this.Descripcion.MinimumWidth = 15;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha ultima Actualizacion";
            this.fecha.MinimumWidth = 15;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // periodoAct
            // 
            this.periodoAct.HeaderText = "Periodo Actualizacicon";
            this.periodoAct.Name = "periodoAct";
            // 
            // grillaVinos
            // 
            this.grillaVinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVinos.Location = new System.Drawing.Point(174, 470);
            this.grillaVinos.Name = "grillaVinos";
            this.grillaVinos.Size = new System.Drawing.Size(441, 239);
            this.grillaVinos.TabIndex = 8;
            // 
            // pantImportadoraActVinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.grillaVinos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSelec);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grillaBodegas);
            this.Name = "pantImportadoraActVinos";
            this.Text = "pantImportadoraActVinos";
            this.Load += new System.EventHandler(this.pantImportadoraActVinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSelec;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView grillaBodegas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoAct;
        private System.Windows.Forms.DataGridView grillaVinos;
    }
}