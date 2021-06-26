
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
            this.cmdBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAgregarArchivo
            // 
            this.cmdAgregarArchivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAgregarArchivo.BackgroundImage")));
            this.cmdAgregarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAgregarArchivo.FlatAppearance.BorderSize = 0;
            this.cmdAgregarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregarArchivo.Location = new System.Drawing.Point(307, 337);
            this.cmdAgregarArchivo.Name = "cmdAgregarArchivo";
            this.cmdAgregarArchivo.Size = new System.Drawing.Size(60, 53);
            this.cmdAgregarArchivo.TabIndex = 9;
            this.cmdAgregarArchivo.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(185, 137);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 30);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Título:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(154, 186);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(126, 30);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.BackColor = System.Drawing.Color.Transparent;
            this.lblArchivo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArchivo.Location = new System.Drawing.Point(127, 337);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(174, 30);
            this.lblArchivo.TabIndex = 12;
            this.lblArchivo.Text = "Agregar archivos:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(292, 137);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(162, 23);
            this.txtTitulo.TabIndex = 13;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(292, 183);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(260, 139);
            this.txtDesc.TabIndex = 14;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAceptar.Location = new System.Drawing.Point(321, 416);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(150, 73);
            this.cmdAceptar.TabIndex = 15;
            this.cmdAceptar.Text = "Agregar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            // 
            // cmdBack
            // 
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Image = ((System.Drawing.Image)(resources.GetObject("cmdBack.Image")));
            this.cmdBack.Location = new System.Drawing.Point(1, 1);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(66, 62);
            this.cmdBack.TabIndex = 16;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // NuevaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmdAgregarArchivo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevaActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Actividad  - Corvus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevaActividad_FormClosed);
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
        private System.Windows.Forms.Button cmdBack;
    }
}