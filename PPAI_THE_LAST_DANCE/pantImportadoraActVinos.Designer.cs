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
            this.grillaVinos = new System.Windows.Forms.DataGridView();
            this.nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSelec1 = new System.Windows.Forms.Label();
            this.labelSelec2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVinos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 452);
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
            this.btnActualizar.Location = new System.Drawing.Point(275, 496);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 38);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grillaBodegas
            // 
            this.grillaBodegas.AllowUserToAddRows = false;
            this.grillaBodegas.AllowUserToDeleteRows = false;
            this.grillaBodegas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grillaBodegas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grillaBodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaBodegas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.grillaBodegas.Location = new System.Drawing.Point(34, 66);
            this.grillaBodegas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grillaBodegas.Name = "grillaBodegas";
            this.grillaBodegas.RowHeadersWidth = 62;
            this.grillaBodegas.Size = new System.Drawing.Size(316, 364);
            this.grillaBodegas.TabIndex = 4;
            this.grillaBodegas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaBodegas_CellClick);
            this.grillaBodegas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaBodegas_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 50;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // grillaVinos
            // 
            this.grillaVinos.AllowUserToAddRows = false;
            this.grillaVinos.AllowUserToDeleteRows = false;
            this.grillaVinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre2,
            this.FechaActualizacion,
            this.añada,
            this.precio});
            this.grillaVinos.Location = new System.Drawing.Point(430, 66);
            this.grillaVinos.Name = "grillaVinos";
            this.grillaVinos.RowHeadersWidth = 102;
            this.grillaVinos.Size = new System.Drawing.Size(828, 364);
            this.grillaVinos.TabIndex = 8;
            this.grillaVinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaVinos_CellContentClick);
            // 
            // nombre2
            // 
            this.nombre2.HeaderText = "Nombre";
            this.nombre2.MinimumWidth = 12;
            this.nombre2.Name = "nombre2";
            this.nombre2.Width = 250;
            // 
            // FechaActualizacion
            // 
            this.FechaActualizacion.HeaderText = "FechaActualizacion";
            this.FechaActualizacion.MinimumWidth = 12;
            this.FechaActualizacion.Name = "FechaActualizacion";
            this.FechaActualizacion.Width = 250;
            // 
            // añada
            // 
            this.añada.HeaderText = "Añada";
            this.añada.MinimumWidth = 12;
            this.añada.Name = "añada";
            this.añada.Width = 250;
            // 
            // precio
            // 
            this.precio.HeaderText = "PrecioARS";
            this.precio.MinimumWidth = 12;
            this.precio.Name = "precio";
            this.precio.Width = 250;
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
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "BODEGAS CON ACTUALIZACION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "RESUMEN VINOS DE ";
            // 
            // labelSelec1
            // 
            this.labelSelec1.AutoSize = true;
            this.labelSelec1.Location = new System.Drawing.Point(179, 452);
            this.labelSelec1.Name = "labelSelec1";
            this.labelSelec1.Size = new System.Drawing.Size(10, 13);
            this.labelSelec1.TabIndex = 13;
            this.labelSelec1.Text = "-";
            // 
            // labelSelec2
            // 
            this.labelSelec2.AutoSize = true;
            this.labelSelec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelec2.Location = new System.Drawing.Point(592, 34);
            this.labelSelec2.Name = "labelSelec2";
            this.labelSelec2.Size = new System.Drawing.Size(11, 13);
            this.labelSelec2.TabIndex = 14;
            this.labelSelec2.Text = "-";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(941, 496);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(175, 38);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Nueva seleccion";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pantImportadoraActVinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1278, 574);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.labelSelec2);
            this.Controls.Add(this.labelSelec1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaAct);
            this.Controls.Add(this.grillaVinos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSelec);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.grillaBodegas);
            this.MaximizeBox = false;
            this.Name = "pantImportadoraActVinos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
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
        private System.Windows.Forms.DataGridView grillaVinos;
        private System.Windows.Forms.Label fechaAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaActualizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn añada;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label labelSelec1;
        private System.Windows.Forms.Label labelSelec2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}