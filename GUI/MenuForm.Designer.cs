
namespace Corvus_Proyecto.GUI
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmdPizarron = new System.Windows.Forms.Button();
            this.cmdGrupos = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.labelNombreDocente = new System.Windows.Forms.Label();
            this.label_Pizarron = new System.Windows.Forms.Label();
            this.label_Grupos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(229, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(144, 30);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "¡Bienvenid@!";
            // 
            // cmdPizarron
            // 
            this.cmdPizarron.BackColor = System.Drawing.SystemColors.Control;
            this.cmdPizarron.FlatAppearance.BorderSize = 0;
            this.cmdPizarron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPizarron.ForeColor = System.Drawing.Color.Transparent;
            this.cmdPizarron.Image = ((System.Drawing.Image)(resources.GetObject("cmdPizarron.Image")));
            this.cmdPizarron.Location = new System.Drawing.Point(117, 331);
            this.cmdPizarron.Name = "cmdPizarron";
            this.cmdPizarron.Size = new System.Drawing.Size(142, 170);
            this.cmdPizarron.TabIndex = 8;
            this.cmdPizarron.UseVisualStyleBackColor = false;
            this.cmdPizarron.Click += new System.EventHandler(this.cmdPizarron_Click);
            // 
            // cmdGrupos
            // 
            this.cmdGrupos.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGrupos.FlatAppearance.BorderSize = 0;
            this.cmdGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGrupos.ForeColor = System.Drawing.Color.Transparent;
            this.cmdGrupos.Image = ((System.Drawing.Image)(resources.GetObject("cmdGrupos.Image")));
            this.cmdGrupos.Location = new System.Drawing.Point(476, 342);
            this.cmdGrupos.Name = "cmdGrupos";
            this.cmdGrupos.Size = new System.Drawing.Size(142, 170);
            this.cmdGrupos.TabIndex = 9;
            this.cmdGrupos.UseVisualStyleBackColor = false;
            this.cmdGrupos.Click += new System.EventHandler(this.cmdGrupos_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Image = ((System.Drawing.Image)(resources.GetObject("cmdBack.Image")));
            this.cmdBack.Location = new System.Drawing.Point(1, 12);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(66, 62);
            this.cmdBack.TabIndex = 10;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // labelNombreDocente
            // 
            this.labelNombreDocente.AutoSize = true;
            this.labelNombreDocente.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreDocente.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelNombreDocente.Location = new System.Drawing.Point(416, 60);
            this.labelNombreDocente.Name = "labelNombreDocente";
            this.labelNombreDocente.Size = new System.Drawing.Size(69, 30);
            this.labelNombreDocente.TabIndex = 11;
            this.labelNombreDocente.Text = "label1";
            // 
            // label_Pizarron
            // 
            this.label_Pizarron.AutoSize = true;
            this.label_Pizarron.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Pizarron.Location = new System.Drawing.Point(100, 515);
            this.label_Pizarron.Name = "label_Pizarron";
            this.label_Pizarron.Size = new System.Drawing.Size(192, 30);
            this.label_Pizarron.TabIndex = 12;
            this.label_Pizarron.Text = "Acceder al Pizarron";
            this.label_Pizarron.Click += new System.EventHandler(this.label_Pizarron_Click);
            // 
            // label_Grupos
            // 
            this.label_Grupos.AutoSize = true;
            this.label_Grupos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Grupos.Location = new System.Drawing.Point(476, 515);
            this.label_Grupos.Name = "label_Grupos";
            this.label_Grupos.Size = new System.Drawing.Size(147, 30);
            this.label_Grupos.TabIndex = 13;
            this.label_Grupos.Text = "Ver los Grupos";
            this.label_Grupos.Click += new System.EventHandler(this.label_Grupos_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label_Grupos);
            this.Controls.Add(this.label_Pizarron);
            this.Controls.Add(this.labelNombreDocente);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdGrupos);
            this.Controls.Add(this.cmdPizarron);
            this.Controls.Add(this.lblWelcome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Corvus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button cmdPizarron;
        private System.Windows.Forms.Button cmdGrupos;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Label labelNombreDocente;
        private System.Windows.Forms.Label label_Pizarron;
        private System.Windows.Forms.Label label_Grupos;
    }
}