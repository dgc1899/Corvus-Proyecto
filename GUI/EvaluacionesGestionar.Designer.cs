
namespace Corvus_Proyecto.GUI
{
    partial class EvaluacionesGestionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluacionesGestionar));
            this.cmdNuevaEvaluacion = new System.Windows.Forms.Button();
            this.listEvaluaciones = new System.Windows.Forms.ListBox();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdNuevaEvaluacion
            // 
            this.cmdNuevaEvaluacion.FlatAppearance.BorderSize = 0;
            this.cmdNuevaEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevaEvaluacion.ForeColor = System.Drawing.Color.White;
            this.cmdNuevaEvaluacion.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevaEvaluacion.Image")));
            this.cmdNuevaEvaluacion.Location = new System.Drawing.Point(321, 475);
            this.cmdNuevaEvaluacion.Name = "cmdNuevaEvaluacion";
            this.cmdNuevaEvaluacion.Size = new System.Drawing.Size(76, 74);
            this.cmdNuevaEvaluacion.TabIndex = 3;
            this.cmdNuevaEvaluacion.UseVisualStyleBackColor = true;
            this.cmdNuevaEvaluacion.Click += new System.EventHandler(this.cmdNuevaEvaluacion_Click);
            // 
            // listEvaluaciones
            // 
            this.listEvaluaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEvaluaciones.FormattingEnabled = true;
            this.listEvaluaciones.ItemHeight = 15;
            this.listEvaluaciones.Location = new System.Drawing.Point(238, 36);
            this.listEvaluaciones.Name = "listEvaluaciones";
            this.listEvaluaciones.Size = new System.Drawing.Size(272, 435);
            this.listEvaluaciones.TabIndex = 4;
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
            this.cmdAtras.TabIndex = 6;
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // EvaluacionesGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.listEvaluaciones);
            this.Controls.Add(this.cmdNuevaEvaluacion);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvaluacionesGestionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Evaluaciones - COrvus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EvaluacionesGestionar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNuevaEvaluacion;
        private System.Windows.Forms.ListBox listEvaluaciones;
        private System.Windows.Forms.Button cmdAtras;
    }
}