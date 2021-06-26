
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
            this.gridEvaluaciones = new System.Windows.Forms.DataGridView();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvaluaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNuevaEvaluacion
            // 
            this.cmdNuevaEvaluacion.FlatAppearance.BorderSize = 0;
            this.cmdNuevaEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevaEvaluacion.ForeColor = System.Drawing.Color.White;
            this.cmdNuevaEvaluacion.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevaEvaluacion.Image")));
            this.cmdNuevaEvaluacion.Location = new System.Drawing.Point(293, 358);
            this.cmdNuevaEvaluacion.Name = "cmdNuevaEvaluacion";
            this.cmdNuevaEvaluacion.Size = new System.Drawing.Size(76, 74);
            this.cmdNuevaEvaluacion.TabIndex = 3;
            this.cmdNuevaEvaluacion.UseVisualStyleBackColor = true;
            this.cmdNuevaEvaluacion.Click += new System.EventHandler(this.cmdNuevaEvaluacion_Click);
            // 
            // gridEvaluaciones
            // 
            this.gridEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEvaluaciones.Location = new System.Drawing.Point(12, 12);
            this.gridEvaluaciones.Name = "gridEvaluaciones";
            this.gridEvaluaciones.RowTemplate.Height = 25;
            this.gridEvaluaciones.Size = new System.Drawing.Size(628, 330);
            this.gridEvaluaciones.TabIndex = 4;
            // 
            // cmdAtras
            // 
            this.cmdAtras.AutoSize = true;
            this.cmdAtras.FlatAppearance.BorderSize = 0;
            this.cmdAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAtras.ForeColor = System.Drawing.Color.Transparent;
            this.cmdAtras.Image = ((System.Drawing.Image)(resources.GetObject("cmdAtras.Image")));
            this.cmdAtras.Location = new System.Drawing.Point(12, 365);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(78, 67);
            this.cmdAtras.TabIndex = 6;
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.FlatAppearance.BorderSize = 0;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.Image")));
            this.cmdEliminar.Location = new System.Drawing.Point(603, 348);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(37, 28);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // EvaluacionesGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 444);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.gridEvaluaciones);
            this.Controls.Add(this.cmdNuevaEvaluacion);
            this.Name = "EvaluacionesGestionar";
            this.Text = "EvaluacionesGestionar";
            this.Load += new System.EventHandler(this.EvaluacionesGestionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEvaluaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNuevaEvaluacion;
        private System.Windows.Forms.DataGridView gridEvaluaciones;
        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.Button cmdEliminar;
    }
}