
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
            this.SuspendLayout();
            // 
            // PnlIconos
            // 
            this.PnlIconos.AutoScroll = true;
            this.PnlIconos.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIconos.Location = new System.Drawing.Point(0, 0);
            this.PnlIconos.Name = "PnlIconos";
            this.PnlIconos.Size = new System.Drawing.Size(432, 450);
            this.PnlIconos.TabIndex = 6;
            // 
            // cmdNuevoGrupo
            // 
            this.cmdNuevoGrupo.FlatAppearance.BorderSize = 0;
            this.cmdNuevoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevoGrupo.ForeColor = System.Drawing.Color.White;
            this.cmdNuevoGrupo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevoGrupo.Image")));
            this.cmdNuevoGrupo.Location = new System.Drawing.Point(490, 364);
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
            this.cmdBack.Location = new System.Drawing.Point(508, 12);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(58, 61);
            this.cmdBack.TabIndex = 0;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // GruposForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.cmdNuevoGrupo);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.PnlIconos);
            this.Name = "GruposForma";
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.GruposForma_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel PnlIconos;
        private System.Windows.Forms.Button cmdNuevoGrupo;
        private System.Windows.Forms.Button cmdBack;
    }
}