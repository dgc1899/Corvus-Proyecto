
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmdPizarron = new System.Windows.Forms.Button();
            this.cmdGrupos = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 143);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(233, 158);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(69, 15);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Bienvenido!";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdPizarron
            // 
            this.cmdPizarron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPizarron.Image = ((System.Drawing.Image)(resources.GetObject("cmdPizarron.Image")));
            this.cmdPizarron.Location = new System.Drawing.Point(12, 196);
            this.cmdPizarron.Name = "cmdPizarron";
            this.cmdPizarron.Size = new System.Drawing.Size(215, 101);
            this.cmdPizarron.TabIndex = 8;
            this.cmdPizarron.UseVisualStyleBackColor = true;
            // 
            // cmdGrupos
            // 
            this.cmdGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGrupos.Image = ((System.Drawing.Image)(resources.GetObject("cmdGrupos.Image")));
            this.cmdGrupos.Location = new System.Drawing.Point(308, 196);
            this.cmdGrupos.Name = "cmdGrupos";
            this.cmdGrupos.Size = new System.Drawing.Size(215, 101);
            this.cmdGrupos.TabIndex = 9;
            this.cmdGrupos.UseVisualStyleBackColor = true;
            // 
            // cmdBack
            // 
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Image = ((System.Drawing.Image)(resources.GetObject("cmdBack.Image")));
            this.cmdBack.Location = new System.Drawing.Point(12, 326);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(66, 62);
            this.cmdBack.TabIndex = 10;
            this.cmdBack.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 391);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdGrupos);
            this.Controls.Add(this.cmdPizarron);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuForm";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button cmdPizarron;
        private System.Windows.Forms.Button cmdGrupos;
        private System.Windows.Forms.Button cmdBack;
    }
}