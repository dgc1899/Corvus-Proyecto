
namespace Corvus_Proyecto
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblId = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.cmdEnter = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cmdTutorial = new System.Windows.Forms.Button();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_cerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(33, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(113, 30);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID Control:";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPass.Location = new System.Drawing.Point(23, 71);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(123, 30);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Contraseña:";
            this.lblPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmdEnter
            // 
            this.cmdEnter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdEnter.Location = new System.Drawing.Point(102, 121);
            this.cmdEnter.Name = "cmdEnter";
            this.cmdEnter.Size = new System.Drawing.Size(108, 43);
            this.cmdEnter.TabIndex = 2;
            this.cmdEnter.Text = "Entrar";
            this.cmdEnter.UseVisualStyleBackColor = true;
            this.cmdEnter.Click += new System.EventHandler(this.cmdEnter_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(158, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 23);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(158, 78);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(125, 23);
            this.txtPass.TabIndex = 4;
            // 
            // cmdTutorial
            // 
            this.cmdTutorial.AutoSize = true;
            this.cmdTutorial.BackColor = System.Drawing.Color.Transparent;
            this.cmdTutorial.FlatAppearance.BorderSize = 0;
            this.cmdTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTutorial.ForeColor = System.Drawing.Color.Transparent;
            this.cmdTutorial.Image = ((System.Drawing.Image)(resources.GetObject("cmdTutorial.Image")));
            this.cmdTutorial.Location = new System.Drawing.Point(-2, 199);
            this.cmdTutorial.Name = "cmdTutorial";
            this.cmdTutorial.Size = new System.Drawing.Size(43, 43);
            this.cmdTutorial.TabIndex = 6;
            this.cmdTutorial.UseVisualStyleBackColor = false;
            this.cmdTutorial.Click += new System.EventHandler(this.cmdTutorial_Click);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.FlatAppearance.BorderSize = 0;
            this.cmdRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdRegistrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cmdRegistrar.Location = new System.Drawing.Point(102, 180);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(119, 37);
            this.cmdRegistrar.TabIndex = 8;
            this.cmdRegistrar.Text = "Regístrate";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmdRegistrar);
            this.panel1.Controls.Add(this.cmdTutorial);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.cmdEnter);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(229, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 244);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox_cerrar
            // 
            this.pictureBox_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_cerrar.BackgroundImage")));
            this.pictureBox_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_cerrar.Location = new System.Drawing.Point(705, 0);
            this.pictureBox_cerrar.Name = "pictureBox_cerrar";
            this.pictureBox_cerrar.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_cerrar.TabIndex = 10;
            this.pictureBox_cerrar.TabStop = false;
            this.pictureBox_cerrar.Click += new System.EventHandler(this.pictureBox_cerrar_Click);
            // 
            // pictureBox_minimizar
            // 
            this.pictureBox_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimizar.BackgroundImage")));
            this.pictureBox_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_minimizar.Location = new System.Drawing.Point(619, 0);
            this.pictureBox_minimizar.Name = "pictureBox_minimizar";
            this.pictureBox_minimizar.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_minimizar.TabIndex = 11;
            this.pictureBox_minimizar.TabStop = false;
            this.pictureBox_minimizar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox_minimizar);
            this.Controls.Add(this.pictureBox_cerrar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Corvus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button cmdEnter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button cmdTutorial;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_cerrar;
        private System.Windows.Forms.PictureBox pictureBox_minimizar;
    }
}

