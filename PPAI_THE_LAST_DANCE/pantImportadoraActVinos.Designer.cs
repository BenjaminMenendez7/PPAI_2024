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
            this.nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notacata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVinos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(834, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bodega seleccionada:";
            // 
            // labelSelec
            // 
            this.labelSelec.AutoSize = true;
            this.labelSelec.Location = new System.Drawing.Point(992, 376);
            this.labelSelec.Name = "labelSelec";
            this.labelSelec.Size = new System.Drawing.Size(0, 13);
            this.labelSelec.TabIndex = 6;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(1128, 371);
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
            this.grillaBodegas.Location = new System.Drawing.Point(98, 66);
            this.grillaBodegas.Name = "grillaBodegas";
            this.grillaBodegas.RowHeadersWidth = 102;
            this.grillaBodegas.Size = new System.Drawing.Size(1105, 267);
            this.grillaBodegas.TabIndex = 4;
            this.grillaBodegas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaBodegas_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "nombre";
            this.Nombre.MinimumWidth = 50;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "descripcion";
            this.Descripcion.MinimumWidth = 15;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha ultima Actualizacion";
            this.fecha.MinimumWidth = 15;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 250;
            // 
            // periodoAct
            // 
            this.periodoAct.HeaderText = "Periodo Actualizacicon";
            this.periodoAct.MinimumWidth = 12;
            this.periodoAct.Name = "periodoAct";
            this.periodoAct.Width = 250;
            // 
            // grillaVinos
            // 
            this.grillaVinos.AllowUserToAddRows = false;
            this.grillaVinos.AllowUserToDeleteRows = false;
            this.grillaVinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre2,
            this.añada,
            this.precio,
            this.notacata});
            this.grillaVinos.Location = new System.Drawing.Point(98, 470);
            this.grillaVinos.Name = "grillaVinos";
            this.grillaVinos.RowHeadersWidth = 102;
            this.grillaVinos.Size = new System.Drawing.Size(1105, 239);
            this.grillaVinos.TabIndex = 8;
            this.grillaVinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaVinos_CellContentClick);
            // 
            // nombre2
            // 
            this.nombre2.HeaderText = "nombre";
            this.nombre2.MinimumWidth = 12;
            this.nombre2.Name = "nombre2";
            this.nombre2.Width = 250;
            // 
            // añada
            // 
            this.añada.HeaderText = "añada";
            this.añada.MinimumWidth = 12;
            this.añada.Name = "añada";
            this.añada.Width = 250;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.MinimumWidth = 12;
            this.precio.Name = "precio";
            this.precio.Width = 250;
            // 
            // notacata
            // 
            this.notacata.HeaderText = "Nota De Cata";
            this.notacata.MinimumWidth = 12;
            this.notacata.Name = "notacata";
            this.notacata.Width = 250;
            // 
            // fechaAct
            // 
            this.fechaAct.AutoSize = true;
            this.fechaAct.Location = new System.Drawing.Point(992, 401);
            this.fechaAct.Name = "fechaAct";
            this.fechaAct.Size = new System.Drawing.Size(0, 13);
            this.fechaAct.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(834, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha Actualizada:";
            // 
            // pantImportadoraActVinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1305, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaAct);
            this.Controls.Add(this.grillaVinos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSelec);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grillaBodegas);
            this.Name = "pantImportadoraActVinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn añada;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn notacata;
        private System.Windows.Forms.Label fechaAct;
        private System.Windows.Forms.Label label1;
    }
}