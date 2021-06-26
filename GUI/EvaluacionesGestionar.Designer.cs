
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
            // EvaluacionesGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 444);
            this.Controls.Add(this.gridEvaluaciones);
            this.Controls.Add(this.cmdNuevaEvaluacion);
            this.Name = "EvaluacionesGestionar";
            this.Text = "EvaluacionesGestionar";
            this.Load += new System.EventHandler(this.EvaluacionesGestionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEvaluaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdNuevaEvaluacion;
        private System.Windows.Forms.DataGridView gridEvaluaciones;
    }
}