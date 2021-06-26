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
                MessageBox.Show(SqliteDataAccess.GetIdDocente().ToString());
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Intentar de nuevo");
            }
        }
    }
}
