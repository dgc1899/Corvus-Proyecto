
namespace Corvus_Proyecto.GUI
{
    partial class GestionarActividadesForm
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
            this.buttonAgregarActividad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAvtividades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAgregarActividad
            // 
            this.buttonAgregarActividad.Location = new System.Drawing.Point(315, 363);
            this.buttonAgregarActividad.Name = "buttonAgregarActividad";
            this.buttonAgregarActividad.Size = new System.Drawing.Size(206, 53);
            this.buttonAgregarActividad.TabIndex = 0;
            this.buttonAgregarActividad.Text = "Agregar Actividad";
            this.buttonAgregarActividad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de actividades:";
            // 
            // listBoxAvtividades
            // 
            this.listBoxAvtividades.FormattingEnabled = true;
            this.listBoxAvtividades.ItemHeight = 15;
            this.listBoxAvtividades.Location = new System.Drawing.Point(40, 78);
            this.listBoxAvtividades.Name = "listBoxAvtividades";
            this.listBoxAvtividades.Size = new System.Drawing.Size(278, 229);
            this.listBoxAvtividades.TabIndex = 2;
            // 
            // GestionarActividadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxAvtividades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAgregarActividad);
            this.Name = "GestionarActividadesForm";
            this.Text = "Actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAvtividades;
    }
}