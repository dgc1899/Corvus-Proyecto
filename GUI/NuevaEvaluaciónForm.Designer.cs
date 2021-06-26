
namespace Corvus_Proyecto.GUI
{
    partial class Nueva_evaluación
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.datepickerFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(12, 123);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(48, 15);
            this.lblUnidad.TabIndex = 2;
            this.lblUnidad.Text = "Unidad:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(90, 57);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(202, 47);
            this.txtDesc.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(90, 21);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 4;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(90, 120);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(46, 23);
            this.txtUnidad.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(10, 170);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(74, 15);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha límite:";
            // 
            // datepickerFecha
            // 
            this.datepickerFecha.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.datepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepickerFecha.Location = new System.Drawing.Point(90, 164);
            this.datepickerFecha.Name = "datepickerFecha";
            this.datepickerFecha.Size = new System.Drawing.Size(206, 23);
            this.datepickerFecha.TabIndex = 12;
            // 
            // Nueva_evaluación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 247);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.datepickerFecha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nueva_evaluación";
            this.Text = "Nueva evaluación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker datepickerFecha;
    }
}