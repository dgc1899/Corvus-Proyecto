
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
            this.SuspendLayout();
            // 
            // cmdNuevaActividad
            // 
            this.cmdNuevaActividad.FlatAppearance.BorderSize = 0;
            this.cmdNuevaActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevaActividad.ForeColor = System.Drawing.Color.White;
            this.cmdNuevaActividad.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevaActividad.Image")));
            this.cmdNuevaActividad.Location = new System.Drawing.Point(187, 358);
            this.cmdNuevaActividad.Name = "cmdNuevaActividad";
            this.cmdNuevaActividad.Size = new System.Drawing.Size(76, 74);
            this.cmdNuevaActividad.TabIndex = 2;
            this.cmdNuevaActividad.UseVisualStyleBackColor = true;
            // 
            // listActividades
            // 
            this.listActividades.FormattingEnabled = true;
            this.listActividades.ItemHeight = 15;
            this.listActividades.Location = new System.Drawing.Point(69, 12);
            this.listActividades.Name = "listActividades";
            this.listActividades.Size = new System.Drawing.Size(287, 319);
            this.listActividades.TabIndex = 3;
            // 
            // ActividadesGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 444);
            this.Controls.Add(this.listActividades);
            this.Controls.Add(this.cmdNuevaActividad);
            this.Name = "ActividadesGestionar";
            this.Text = "ActividadesGestionar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdNuevaActividad;
        private System.Windows.Forms.ListBox listActividades;
    }
}