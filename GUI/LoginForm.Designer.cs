
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.cmdEnter = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdTutorial = new System.Windows.Forms.Button();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(95, 159);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(75, 202);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(70, 15);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Contraseña:";
            this.lblPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmdEnter
            // 
            this.cmdEnter.Location = new System.Drawing.Point(136, 269);
            this.cmdEnter.Name = "cmdEnter";
            this.cmdEnter.Size = new System.Drawing.Size(87, 23);
            this.cmdEnter.TabIndex = 2;
            this.cmdEnter.Text = "Entrar";
            this.cmdEnter.UseVisualStyleBackColor = true;
            this.cmdEnter.Click += new System.EventHandler(this.cmdEnter_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(151, 156);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(125, 23);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(152, 199);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(125, 23);
            this.txtPass.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 143);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cmdTutorial
            // 
            this.cmdTutorial.AutoSize = true;
            this.cmdTutorial.BackColor = System.Drawing.Color.Transparent;
            this.cmdTutorial.FlatAppearance.BorderSize = 0;
            this.cmdTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTutorial.ForeColor = System.Drawing.Color.Transparent;
            this.cmdTutorial.Image = ((System.Drawing.Image)(resources.GetObject("cmdTutorial.Image")));
            this.cmdTutorial.Location = new System.Drawing.Point(12, 259);
            this.cmdTutorial.Name = "cmdTutorial";
            this.cmdTutorial.Size = new System.Drawing.Size(43, 43);
            this.cmdTutorial.TabIndex = 6;
            this.cmdTutorial.UseVisualStyleBackColor = false;
            this.cmdTutorial.Click += new System.EventHandler(this.cmdTutorial_Click);
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRegistrar.Location = new System.Drawing.Point(267, 277);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(59, 15);
            this.lblRegistrar.TabIndex = 7;
            this.lblRegistrar.Text = "Registrate";
            this.lblRegistrar.Click += new System.EventHandler(this.lblRegistrar_Click);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.FlatAppearance.BorderSize = 0;
            this.cmdRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistrar.Location = new System.Drawing.Point(151, 317);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(63, 19);
            this.cmdRegistrar.TabIndex = 8;
            this.cmdRegistrar.Text = "button1";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 348);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.lblRegistrar);
            this.Controls.Add(this.cmdTutorial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cmdEnter);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button cmdEnter;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdTutorial;
        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.Button cmdRegistrar;
    }
}

