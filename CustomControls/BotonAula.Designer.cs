
namespace Corvus_Proyecto.CustomControls
{
    partial class BotonAula
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotonAula));
            this.button1 = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 102);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Location = new System.Drawing.Point(0, 102);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(45, 15);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Default";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.button1);
            this.Name = "BotonAula";
            this.Size = new System.Drawing.Size(171, 129);
            this.MouseEnter += new System.EventHandler(this.BotonAula_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.BotonAula_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblText;
    }
}
