
namespace Corvus_Proyecto.GUI
{
    partial class NuevaActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaActividad));
            this.cmdAgregarArchivo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAgregarArchivo
            // 
            this.cmdAgregarArchivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAgregarArchivo.BackgroundImage")));
            this.cmdAgregarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAgregarArchivo.FlatAppearance.BorderSize = 0;
            this.cmdAgregarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregarArchivo.Location = new System.Drawing.Point(123, 223);
            this.cmdAgregarArchivo.Name = "cmdAgregarArchivo";
            this.cmdAgregarArchivo.Size = new System.Drawing.Size(60, 53);
            this.cmdAgregarArchivo.TabIndex = 9;
            this.cmdAgregarArchivo.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(76, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(41, 15);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Título:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(45, 81);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(72, 15);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(18, 232);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(99, 15);
            this.lblArchivo.TabIndex = 12;
            this.lblArchivo.Text = "Agregar archivos:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(183, 32);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(162, 23);
            this.txtTitulo.TabIndex = 13;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(183, 78);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(260, 139);
            this.txtDesc.TabIndex = 14;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(283, 290);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar.TabIndex = 15;
            this.cmdAceptar.Text = "Agregar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            // 
            // NuevaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 325);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmdAgregarArchivo);
            this.Name = "NuevaActividad";
            this.Text = "NuevaActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAgregarArchivo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button cmdAceptar;
    }
}