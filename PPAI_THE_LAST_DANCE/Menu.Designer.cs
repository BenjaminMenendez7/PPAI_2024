﻿namespace PPAI_THE_LAST_DANCE
{
    partial class Menu
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
            this.btnImportarActVin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportarActVin
            // 
            this.btnImportarActVin.Location = new System.Drawing.Point(369, 217);
            this.btnImportarActVin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportarActVin.Name = "btnImportarActVin";
            this.btnImportarActVin.Size = new System.Drawing.Size(260, 96);
            this.btnImportarActVin.TabIndex = 0;
            this.btnImportarActVin.Text = "Importar actualizacion vinos";
            this.btnImportarActVin.UseVisualStyleBackColor = true;
            this.btnImportarActVin.Click += new System.EventHandler(this.btnImportarActVin_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnImportarActVin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportarActVin;
    }
}