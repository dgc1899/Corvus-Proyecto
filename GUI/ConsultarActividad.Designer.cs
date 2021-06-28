
namespace Corvus_Proyecto.GUI
{
    partial class ConsultarActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarActividad));
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox_cerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAceptar.Location = new System.Drawing.Point(323, 447);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(140, 60);
            this.cmdAceptar.TabIndex = 20;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(145, 91);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(260, 139);
            this.txtDesc.TabIndex = 19;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(145, 42);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(260, 23);
            this.txtTitulo.TabIndex = 18;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(13, 91);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(126, 30);
            this.lblDesc.TabIndex = 17;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(13, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 30);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Título:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(178, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 270);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox_minimizar
            // 
            this.pictureBox_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimizar.BackgroundImage")));
            this.pictureBox_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_minimizar.Location = new System.Drawing.Point(618, 0);
            this.pictureBox_minimizar.Name = "pictureBox_minimizar";
            this.pictureBox_minimizar.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_minimizar.TabIndex = 23;
            this.pictureBox_minimizar.TabStop = false;
            this.pictureBox_minimizar.Click += new System.EventHandler(this.pictureBox_minimizar_Click);
            // 
            // pictureBox_cerrar
            // 
            this.pictureBox_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_cerrar.BackgroundImage")));
            this.pictureBox_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_cerrar.Location = new System.Drawing.Point(704, 0);
            this.pictureBox_cerrar.Name = "pictureBox_cerrar";
            this.pictureBox_cerrar.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_cerrar.TabIndex = 22;
            this.pictureBox_cerrar.TabStop = false;
            this.pictureBox_cerrar.Click += new System.EventHandler(this.pictureBox_cerrar_Click);
            // 
            // ConsultarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox_minimizar);
            this.Controls.Add(this.pictureBox_cerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Actividad  - Corvus";
            this.Load += new System.EventHandler(this.ConsultarActividad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_minimizar;
        private System.Windows.Forms.PictureBox pictureBox_cerrar;
    }
}