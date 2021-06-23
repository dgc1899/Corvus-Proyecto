
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
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdNuevoGrupo = new System.Windows.Forms.Button();
            this.cmdGrupo_1 = new System.Windows.Forms.Button();
            this.lblGrupo_1 = new System.Windows.Forms.Label();
            this.cmdGrupo_2 = new System.Windows.Forms.Button();
            this.lblGrupo_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdBack
            // 
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.ForeColor = System.Drawing.Color.White;
            this.cmdBack.Image = ((System.Drawing.Image)(resources.GetObject("cmdBack.Image")));
            this.cmdBack.Location = new System.Drawing.Point(12, 377);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(58, 61);
            this.cmdBack.TabIndex = 0;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdNuevoGrupo
            // 
            this.cmdNuevoGrupo.FlatAppearance.BorderSize = 0;
            this.cmdNuevoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevoGrupo.ForeColor = System.Drawing.Color.White;
            this.cmdNuevoGrupo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevoGrupo.Image")));
            this.cmdNuevoGrupo.Location = new System.Drawing.Point(712, 364);
            this.cmdNuevoGrupo.Name = "cmdNuevoGrupo";
            this.cmdNuevoGrupo.Size = new System.Drawing.Size(76, 74);
            this.cmdNuevoGrupo.TabIndex = 1;
            this.cmdNuevoGrupo.UseVisualStyleBackColor = true;
            this.cmdNuevoGrupo.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdGrupo_1
            // 
            this.cmdGrupo_1.FlatAppearance.BorderSize = 0;
            this.cmdGrupo_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGrupo_1.ForeColor = System.Drawing.Color.White;
            this.cmdGrupo_1.Image = ((System.Drawing.Image)(resources.GetObject("cmdGrupo_1.Image")));
            this.cmdGrupo_1.Location = new System.Drawing.Point(74, 90);
            this.cmdGrupo_1.Name = "cmdGrupo_1";
            this.cmdGrupo_1.Size = new System.Drawing.Size(200, 200);
            this.cmdGrupo_1.TabIndex = 2;
            this.cmdGrupo_1.UseVisualStyleBackColor = true;
            // 
            // lblGrupo_1
            // 
            this.lblGrupo_1.AutoSize = true;
            this.lblGrupo_1.Location = new System.Drawing.Point(152, 293);
            this.lblGrupo_1.Name = "lblGrupo_1";
            this.lblGrupo_1.Size = new System.Drawing.Size(49, 15);
            this.lblGrupo_1.TabIndex = 3;
            this.lblGrupo_1.Text = "Grupo 1";
            // 
            // cmdGrupo_2
            // 
            this.cmdGrupo_2.FlatAppearance.BorderSize = 0;
            this.cmdGrupo_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGrupo_2.ForeColor = System.Drawing.Color.White;
            this.cmdGrupo_2.Image = ((System.Drawing.Image)(resources.GetObject("cmdGrupo_2.Image")));
            this.cmdGrupo_2.Location = new System.Drawing.Point(479, 90);
            this.cmdGrupo_2.Name = "cmdGrupo_2";
            this.cmdGrupo_2.Size = new System.Drawing.Size(200, 200);
            this.cmdGrupo_2.TabIndex = 4;
            this.cmdGrupo_2.UseVisualStyleBackColor = true;
            // 
            // lblGrupo_2
            // 
            this.lblGrupo_2.AutoSize = true;
            this.lblGrupo_2.Location = new System.Drawing.Point(562, 293);
            this.lblGrupo_2.Name = "lblGrupo_2";
            this.lblGrupo_2.Size = new System.Drawing.Size(49, 15);
            this.lblGrupo_2.TabIndex = 5;
            this.lblGrupo_2.Text = "Grupo 2";
            // 
            // GruposForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGrupo_2);
            this.Controls.Add(this.cmdGrupo_2);
            this.Controls.Add(this.lblGrupo_1);
            this.Controls.Add(this.cmdGrupo_1);
            this.Controls.Add(this.cmdNuevoGrupo);
            this.Controls.Add(this.cmdBack);
            this.Name = "GruposForma";
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.GruposForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button cmdNuevoGrupo;
        private System.Windows.Forms.Button cmdGrupo_1;
        private System.Windows.Forms.Label lblGrupo_1;
        private System.Windows.Forms.Button cmdGrupo_2;
        private System.Windows.Forms.Label lblGrupo_2;
    }
}