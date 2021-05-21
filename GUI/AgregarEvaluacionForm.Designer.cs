
namespace Corvus_Proyecto.GUI
{
    partial class AgregarEvaluacionForm
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelAgregarArchivo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonAgregarActividad = new System.Windows.Forms.Button();
            this.buttonSeleccionarArchivo = new System.Windows.Forms.Button();
            this.dateTimePickerEvaluacion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(34, 40);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(40, 15);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(34, 83);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(72, 15);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(34, 209);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(36, 15);
            this.labelValor.TabIndex = 2;
            this.labelValor.Text = "Valor:";
            // 
            // labelAgregarArchivo
            // 
            this.labelAgregarArchivo.AutoSize = true;
            this.labelAgregarArchivo.Location = new System.Drawing.Point(31, 313);
            this.labelAgregarArchivo.Name = "labelAgregarArchivo";
            this.labelAgregarArchivo.Size = new System.Drawing.Size(94, 15);
            this.labelAgregarArchivo.TabIndex = 3;
            this.labelAgregarArchivo.Text = "Agregar archivo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 101);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 23);
            this.textBox3.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(528, 165);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 19);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Publicar ahora";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(528, 190);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 19);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Agendar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarActividad
            // 
            this.buttonAgregarActividad.Location = new System.Drawing.Point(209, 408);
            this.buttonAgregarActividad.Name = "buttonAgregarActividad";
            this.buttonAgregarActividad.Size = new System.Drawing.Size(201, 30);
            this.buttonAgregarActividad.TabIndex = 10;
            this.buttonAgregarActividad.Text = "Agregar";
            this.buttonAgregarActividad.UseVisualStyleBackColor = true;
            // 
            // buttonSeleccionarArchivo
            // 
            this.buttonSeleccionarArchivo.Location = new System.Drawing.Point(159, 308);
            this.buttonSeleccionarArchivo.Name = "buttonSeleccionarArchivo";
            this.buttonSeleccionarArchivo.Size = new System.Drawing.Size(169, 29);
            this.buttonSeleccionarArchivo.TabIndex = 11;
            this.buttonSeleccionarArchivo.Text = "Seleccionar archivo";
            this.buttonSeleccionarArchivo.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEvaluacion
            // 
            this.dateTimePickerEvaluacion.Location = new System.Drawing.Point(528, 235);
            this.dateTimePickerEvaluacion.Name = "dateTimePickerEvaluacion";
            this.dateTimePickerEvaluacion.Size = new System.Drawing.Size(245, 23);
            this.dateTimePickerEvaluacion.TabIndex = 12;
            // 
            // AgregarEvaluacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerEvaluacion);
            this.Controls.Add(this.buttonSeleccionarArchivo);
            this.Controls.Add(this.buttonAgregarActividad);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAgregarArchivo);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelTitulo);
            this.Name = "AgregarEvaluacionForm";
            this.Text = "Nueva evaluación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelAgregarArchivo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button buttonAgregarActividad;
        private System.Windows.Forms.Button buttonSeleccionarArchivo;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvaluacion;
    }
}