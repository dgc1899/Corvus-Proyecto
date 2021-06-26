
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
            this.listActividades = new System.Windows.Forms.ListBox();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdNuevaActividad
            // 
            this.cmdNuevaActividad.FlatAppearance.BorderSize = 0;
            this.cmdNuevaActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevaActividad.ForeColor = System.Drawing.Color.White;
            this.cmdNuevaActividad.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevaActividad.Image")));
            this.cmdNuevaActividad.Location = new System.Drawing.Point(324, 475);
            this.cmdNuevaActividad.Name = "cmdNuevaActividad";
            this.cmdNuevaActividad.Size = new System.Drawing.Size(76, 74);
            this.cmdNuevaActividad.TabIndex = 2;
            this.cmdNuevaActividad.UseVisualStyleBackColor = true;
            this.cmdNuevaActividad.Click += new System.EventHandler(this.cmdNuevaActividad_Click);
            // 
            // listActividades
            // 
            this.listActividades.FormattingEnabled = true;
            this.listActividades.ItemHeight = 15;
            this.listActividades.Location = new System.Drawing.Point(238, 36);
            this.listActividades.Name = "listActividades";
            this.listActividades.Size = new System.Drawing.Size(272, 424);
            this.listActividades.TabIndex = 3;
            // 
            // cmdAtras
            // 
            this.cmdAtras.AutoSize = true;
            this.cmdAtras.FlatAppearance.BorderSize = 0;
            this.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAtras.ForeColor = System.Drawing.Color.Transparent;
            this.cmdAtras.Image = ((System.Drawing.Image)(resources.GetObject("cmdAtras.Image")));
            this.cmdAtras.Location = new System.Drawing.Point(-1, -1);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(78, 67);
            this.cmdAtras.TabIndex = 6;
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // ActividadesGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.listActividades);
            this.Controls.Add(this.cmdNuevaActividad);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActividadesGestionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Actividades - Corvus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActividadesGestionar_FormClosed);
            this.Load += new System.EventHandler(this.ActividadesGestionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNuevaActividad;
        private System.Windows.Forms.ListBox listActividades;
        private System.Windows.Forms.Button cmdAtras;
    }
}