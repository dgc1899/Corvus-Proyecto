using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corvus_Proyecto.GUI;
using Corvus_Proyecto.Model;
using Corvus_Proyecto.Dto;
using Corvus_Proyecto.Controllers;

namespace Corvus_Proyecto
{
    public partial class LoginForm : Form
    {
        int idDocente;
        DocenteController docenteController=new DocenteController();
        LoginDto loginDto = new LoginDto();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdTutorial_Click(object sender, EventArgs e)
        {

        }

        private void cmdEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Llenar Campos");
                }
                else
                {
                    loginDto.IdDocente =Convert.ToInt32(txtId.Text.Trim());
                    loginDto.pass = txtPass.Text.Trim();
                    bool verify= docenteController.Login(loginDto);

                    if (verify == true)
                    {
                        idDocente = Convert.ToInt32(txtId.Text.Trim());
                        SqliteDataAccess.SetIdDocente(idDocente);
                        MenuForm menu = new MenuForm();
                        this.Hide();
                        menu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Intentar de nuevo");
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }


        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {
         
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarForm registrarForm = new RegistrarForm();
            this.Hide();
            registrarForm.Show();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
