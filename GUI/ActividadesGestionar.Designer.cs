
namespace Corvus_Proyecto.GUI
{
    partial class ActividadesGestionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActividadesGestionar));
            this.cmdNuevaActividad = new System.Windows.Forms.Button();
            this.gridActividades = new System.Windows.Forms.DataGridView();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNuevaActividad
            // 
            this.cmdNuevaActividad.FlatAppearance.BorderSize = 0;
            this.cmdNuevaActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevaActividad.ForeColor = System.Drawing.Color.White;
            this.cmdNuevaActividad.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevaActividad.Image")));
            this.cmdNuevaActividad.Location = new System.Drawing.Point(299, 430);
            this.cmdNuevaActividad.Name = "cmdNuevaActividad";
            this.cmdNuevaActividad.Size = new System.Drawing.Size(76, 74);
            this.cmdNuevaActividad.TabIndex = 2;
            this.cmdNuevaActividad.UseVisualStyleBackColor = true;
            this.cmdNuevaActividad.Click += new System.EventHandler(this.cmdNuevaActividad_Click);
            // 
            // gridActividades
            // 
            this.gridActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActividades.Location = new System.Drawing.Point(12, 83);
            this.gridActividades.Name = "gridActividades";
            this.gridActividades.RowTemplate.Height = 25;
            this.gridActividades.Size = new System.Drawing.Size(628, 327);
            this.gridActividades.TabIndex = 3;
            // 
            // cmdAtras
            // 
            this.cmdAtras.AutoSize = true;
            this.cmdAtras.FlatAppearance.BorderSize = 0;
            this.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAtras.ForeColor = System.Drawing.Color.Transparent;
            this.cmdAtras.Image = ((System.Drawing.Image)(resources.GetObject("cmdAtras.Image")));
            this.cmdAtras.Location = new System.Drawing.Point(12, 12);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(76, 65);
            this.cmdAtras.TabIndex = 7;
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.FlatAppearance.BorderSize = 0;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.Image")));
            this.cmdEliminar.Location = new System.Drawing.Point(607, 416);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(33, 32);
            this.cmdEliminar.TabIndex = 8;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // ActividadesGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 501);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.gridActividades);
            this.Controls.Add(this.cmdNuevaActividad);
            this.Name = "ActividadesGestionar";
            this.Text = "ActividadesGestionar";
            this.Load += new System.EventHandler(this.ActividadesGestionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNuevaActividad;
        private System.Windows.Forms.DataGridView gridActividades;
        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.Button cmdEliminar;
    }
}