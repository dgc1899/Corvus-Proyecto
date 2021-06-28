
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.pictureBox_minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox_cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // listActividades
            // 
            this.listActividades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listActividades.FormattingEnabled = true;
            this.listActividades.ItemHeight = 15;
            this.listActividades.Location = new System.Drawing.Point(12, 12);
            this.listActividades.Name = "listActividades";
            this.listActividades.Size = new System.Drawing.Size(141, 334);
            this.listActividades.TabIndex = 0;
            this.listActividades.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listActividades_MouseDoubleClick);
            // 
            // cmdActividades
            // 
            this.cmdActividades.AutoSize = true;
            this.cmdActividades.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdActividades.Location = new System.Drawing.Point(252, 110);
            this.cmdActividades.Name = "cmdActividades";
            this.cmdActividades.Size = new System.Drawing.Size(236, 40);
            this.cmdActividades.TabIndex = 1;
            this.cmdActividades.Text = "Gestionar Actividades";
            this.cmdActividades.UseVisualStyleBackColor = true;
            this.cmdActividades.Click += new System.EventHandler(this.cmdActividades_Click);
            // 
            // cmdEval
            // 
            this.cmdEval.AutoSize = true;
            this.cmdEval.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdEval.Location = new System.Drawing.Point(252, 187);
            this.cmdEval.Name = "cmdEval";
            this.cmdEval.Size = new System.Drawing.Size(236, 40);
            this.cmdEval.TabIndex = 2;
            this.cmdEval.Text = "Gestionar Evaluaciones";
            this.cmdEval.UseVisualStyleBackColor = true;
            this.cmdEval.Click += new System.EventHandler(this.cmdEval_Click);
            // 
            // cmdMiembros
            // 
            this.cmdMiembros.AutoSize = true;
            this.cmdMiembros.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdMiembros.Location = new System.Drawing.Point(191, 384);
            this.cmdMiembros.Name = "cmdMiembros";
            this.cmdMiembros.Size = new System.Drawing.Size(213, 40);
            this.cmdMiembros.TabIndex = 3;
            this.cmdMiembros.Text = "Miembros del Grupo";
            this.cmdMiembros.UseVisualStyleBackColor = true;
            this.cmdMiembros.Click += new System.EventHandler(this.cmdMiembros_Click);
            // 
            // cmdOpciones
            // 
            this.cmdOpciones.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdOpciones.Location = new System.Drawing.Point(433, 381);
            this.cmdOpciones.Name = "cmdOpciones";
            this.cmdOpciones.Size = new System.Drawing.Size(152, 47);
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
            this.cmdAtras.Location = new System.Drawing.Point(0, 355);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(78, 67);
            this.cmdAtras.TabIndex = 5;
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(174, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 561);
            this.label1.TabIndex = 6;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdRefresh.Location = new System.Drawing.Point(191, 12);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(46, 48);
            this.cmdRefresh.TabIndex = 7;
            this.cmdRefresh.Text = "R";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // pictureBox_minimizar
            // 
            this.pictureBox_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimizar.BackgroundImage")));
            this.pictureBox_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_minimizar.Location = new System.Drawing.Point(617, 1);
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
            this.pictureBox_cerrar.Location = new System.Drawing.Point(703, 1);
            this.pictureBox_cerrar.Name = "pictureBox_cerrar";
            this.pictureBox_cerrar.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_cerrar.TabIndex = 12;
            this.pictureBox_cerrar.TabStop = false;
            this.pictureBox_cerrar.Click += new System.EventHandler(this.pictureBox_cerrar_Click);
            // 
            // GrupoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox_minimizar);
            this.Controls.Add(this.pictureBox_cerrar);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.cmdOpciones);
            this.Controls.Add(this.cmdMiembros);
            this.Controls.Add(this.cmdEval);
            this.Controls.Add(this.cmdActividades);
            this.Controls.Add(this.listActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrupoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo - Corvus";
            this.Load += new System.EventHandler(this.GrupoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listActividades;
        private System.Windows.Forms.Button cmdActividades;
        private System.Windows.Forms.Button cmdEval;
        private System.Windows.Forms.Button cmdMiembros;
        private System.Windows.Forms.Button cmdOpciones;
        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.PictureBox pictureBox_minimizar;
        private System.Windows.Forms.PictureBox pictureBox_cerrar;
    }
}