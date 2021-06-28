using Corvus_Proyecto.Controllers;
using Corvus_Proyecto.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corvus_Proyecto.GUI
{
    public partial class RegistrarForm : Form
    {
        LoginDto loginDto = new LoginDto();
        DocenteController docenteController = new DocenteController();

        public RegistrarForm()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            loginDto.user = textBox1.Text.Trim();
            loginDto.pass = textBox2.Text.Trim();

            bool registro = docenteController.Registar(loginDto);
            if(registro == true)
            {
                MessageBox.Show("Registro completado");

                //Llamada a metodo para conseguir el ID del docente que se acaba de  registrar
                int idInsertado = docenteController.GetIdDocente();
                MessageBox.Show("ID: "+idInsertado.ToString(),"Tu ID");

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Intentar de nuevo");
            }
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new();
            loginForm.Show();
            this.Hide();
        }

        private void RegistrarForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_cerrar_Click(object sender, EventArgs e)
        {
            string message = "¿Desea cerrar la aplicación?";
            string caption = "Cerrar programa - Corvus";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(message, caption, buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
