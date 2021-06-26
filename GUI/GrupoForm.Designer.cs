
namespace Corvus_Proyecto.GUI
{
    partial class GrupoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrupoForm));
            this.listActividades = new System.Windows.Forms.ListBox();
            this.cmdActividades = new System.Windows.Forms.Button();
            this.cmdEval = new System.Windows.Forms.Button();
            this.cmdMiembros = new System.Windows.Forms.Button();
            this.cmdOpciones = new System.Windows.Forms.Button();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listActividades
            // 
            this.listActividades.FormattingEnabled = true;
            this.listActividades.ItemHeight = 15;
            this.listActividades.Location = new System.Drawing.Point(12, 73);
            this.listActividades.Name = "listActividades";
            this.listActividades.Size = new System.Drawing.Size(201, 484);
            this.listActividades.TabIndex = 0;
            // 
            // cmdActividades
            // 
            this.cmdActividades.AutoSize = true;
            this.cmdActividades.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdActividades.Location = new System.Drawing.Point(355, 118);
            this.cmdActividades.Name = "cmdActividades";
            this.cmdActividades.Size = new System.Drawing.Size(240, 80);
            this.cmdActividades.TabIndex = 1;
            this.cmdActividades.Text = "Gestionar actividades";
            this.cmdActividades.UseVisualStyleBackColor = true;
            this.cmdActividades.Click += new System.EventHandler(this.cmdActividades_Click);
            // 
            // cmdEval
            // 
            this.cmdEval.AutoSize = true;
            this.cmdEval.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdEval.Location = new System.Drawing.Point(355, 236);
            this.cmdEval.Name = "cmdEval";
            this.cmdEval.Size = new System.Drawing.Size(240, 80);
            this.cmdEval.TabIndex = 2;
            this.cmdEval.Text = "Gestionar evaluaciones";
            this.cmdEval.UseVisualStyleBackColor = true;
            this.cmdEval.Click += new System.EventHandler(this.cmdEval_Click);
            // 
            // cmdMiembros
            // 
            this.cmdMiembros.AutoSize = true;
            this.cmdMiembros.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdMiembros.Location = new System.Drawing.Point(241, 401);
            this.cmdMiembros.Name = "cmdMiembros";
            this.cmdMiembros.Size = new System.Drawing.Size(240, 80);
            this.cmdMiembros.TabIndex = 3;
            this.cmdMiembros.Text = "Miembros del grupo";
            this.cmdMiembros.UseVisualStyleBackColor = true;
            this.cmdMiembros.Click += new System.EventHandler(this.cmdMiembros_Click);
            // 
            // cmdOpciones
            // 
            this.cmdOpciones.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdOpciones.Location = new System.Drawing.Point(512, 401);
            this.cmdOpciones.Name = "cmdOpciones";
            this.cmdOpciones.Size = new System.Drawing.Size(240, 80);
            this.cmdOpciones.TabIndex = 4;
            this.cmdOpciones.Text = "Opciones";
            this.cmdOpciones.UseVisualStyleBackColor = true;
            this.cmdOpciones.Click += new System.EventHandler(this.cmdOpciones_Click);
            // 
            // cmdAtras
            // 
            this.cmdAtras.AutoSize = true;
            this.cmdAtras.FlatAppearance.BorderSize = 0;
            this.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAtras.ForeColor = System.Drawing.Color.Transparent;
            this.cmdAtras.Image = ((System.Drawing.Image)(resources.GetObject("cmdAtras.Image")));
            this.cmdAtras.Location = new System.Drawing.Point(-1, 0);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(78, 67);
            this.cmdAtras.TabIndex = 5;
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // GrupoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.cmdOpciones);
            this.Controls.Add(this.cmdMiembros);
            this.Controls.Add(this.cmdEval);
            this.Controls.Add(this.cmdActividades);
            this.Controls.Add(this.listActividades);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrupoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Grupo - Corvus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GrupoForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listActividades;
        private System.Windows.Forms.Button cmdActividades;
        private System.Windows.Forms.Button cmdEval;
        private System.Windows.Forms.Button cmdMiembros;
        private System.Windows.Forms.Button cmdOpciones;
        private System.Windows.Forms.Button cmdAtras;
    }
}