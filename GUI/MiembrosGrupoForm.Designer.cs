
namespace Corvus_Proyecto.GUI
{
    partial class Miembros_de_Grupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miembros_de_Grupo));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.gridAlumnos = new System.Windows.Forms.DataGridView();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.pictureBox_minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox_cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(271, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(539, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 23);
            this.textBox1.TabIndex = 3;
            // 
            // cmdAtras
            // 
            this.cmdAtras.AutoSize = true;
            this.cmdAtras.FlatAppearance.BorderSize = 0;
            this.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAtras.ForeColor = System.Drawing.Color.Transparent;
            this.cmdAtras.Image = ((System.Drawing.Image)(resources.GetObject("cmdAtras.Image")));
            this.cmdAtras.Location = new System.Drawing.Point(0, -1);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(80, 80);
            this.cmdAtras.TabIndex = 6;
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos.Location = new System.Drawing.Point(73, 153);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.RowTemplate.Height = 25;
            this.gridAlumnos.Size = new System.Drawing.Size(460, 248);
            this.gridAlumnos.TabIndex = 7;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.FlatAppearance.BorderSize = 0;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.Image")));
            this.cmdEliminar.Location = new System.Drawing.Point(500, 115);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(33, 32);
            this.cmdEliminar.TabIndex = 9;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // pictureBox_minimizar
            // 
            this.pictureBox_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimizar.BackgroundImage")));
            this.pictureBox_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_minimizar.Location = new System.Drawing.Point(618, -1);
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
            this.pictureBox_cerrar.Location = new System.Drawing.Point(704, -1);
            this.pictureBox_cerrar.Name = "pictureBox_cerrar";
            this.pictureBox_cerrar.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_cerrar.TabIndex = 12;
            this.pictureBox_cerrar.TabStop = false;
            this.pictureBox_cerrar.Click += new System.EventHandler(this.pictureBox_cerrar_Click);
            // 
            // Miembros_de_Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox_minimizar);
            this.Controls.Add(this.pictureBox_cerrar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.gridAlumnos);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Miembros_de_Grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miembros del Grupo - Corvus";
            this.Load += new System.EventHandler(this.Miembros_de_Grupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.DataGridView gridAlumnos;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.PictureBox pictureBox_minimizar;
        private System.Windows.Forms.PictureBox pictureBox_cerrar;
    }
}