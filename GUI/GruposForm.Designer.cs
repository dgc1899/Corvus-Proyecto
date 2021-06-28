
namespace Corvus_Proyecto.GUI
{
    partial class GruposForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GruposForma));
            this.PnlIconos = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdNuevoGrupo = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.pictureBox_minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox_cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlIconos
            // 
            this.PnlIconos.AutoScroll = true;
            this.PnlIconos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PnlIconos.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIconos.Location = new System.Drawing.Point(0, 0);
            this.PnlIconos.Name = "PnlIconos";
            this.PnlIconos.Size = new System.Drawing.Size(432, 561);
            this.PnlIconos.TabIndex = 6;
            // 
            // cmdNuevoGrupo
            // 
            this.cmdNuevoGrupo.FlatAppearance.BorderSize = 0;
            this.cmdNuevoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevoGrupo.ForeColor = System.Drawing.Color.White;
            this.cmdNuevoGrupo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevoGrupo.Image")));
            this.cmdNuevoGrupo.Location = new System.Drawing.Point(438, 487);
            this.cmdNuevoGrupo.Name = "cmdNuevoGrupo";
            this.cmdNuevoGrupo.Size = new System.Drawing.Size(76, 74);
            this.cmdNuevoGrupo.TabIndex = 1;
            this.cmdNuevoGrupo.UseVisualStyleBackColor = true;
            this.cmdNuevoGrupo.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.ForeColor = System.Drawing.Color.White;
            this.cmdBack.Image = ((System.Drawing.Image)(resources.GetObject("cmdBack.Image")));
            this.cmdBack.Location = new System.Drawing.Point(438, 0);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(80, 80);
            this.cmdBack.TabIndex = 0;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // pictureBox_minimizar
            // 
            this.pictureBox_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimizar.BackgroundImage")));
            this.pictureBox_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_minimizar.Location = new System.Drawing.Point(619, 0);
            this.pictureBox_minimizar.Name = "pictureBox_minimizar";
            this.pictureBox_minimizar.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_minimizar.TabIndex = 13;
            this.pictureBox_minimizar.TabStop = false;
            this.pictureBox_minimizar.Click += new System.EventHandler(this.pictureBox_minimizar_Click);
            // 
            // pictureBox_cerrar
            // 
            this.pictureBox_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_cerrar.BackgroundImage")));
            this.pictureBox_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_cerrar.Location = new System.Drawing.Point(705, 0);
            this.pictureBox_cerrar.Name = "pictureBox_cerrar";
            this.pictureBox_cerrar.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_cerrar.TabIndex = 12;
            this.pictureBox_cerrar.TabStop = false;
            this.pictureBox_cerrar.Click += new System.EventHandler(this.pictureBox_cerrar_Click);
            // 
            // GruposForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox_minimizar);
            this.Controls.Add(this.pictureBox_cerrar);
            this.Controls.Add(this.cmdNuevoGrupo);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.PnlIconos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GruposForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos - Corvus";
            this.Load += new System.EventHandler(this.GruposForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel PnlIconos;
        private System.Windows.Forms.Button cmdNuevoGrupo;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.PictureBox pictureBox_minimizar;
        private System.Windows.Forms.PictureBox pictureBox_cerrar;
    }
}