using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corvus_Proyecto.GUI.Pizarron;

namespace Corvus_Proyecto.GUI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdGrupos_Click(object sender, EventArgs e)
        {
            GruposForma gruposForma = new GruposForma();
            this.Hide();
            gruposForma.Show();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForma = new LoginForm();
            this.Hide();
            loginForma.Show();
        }

        private void cmdPizarron_Click(object sender, EventArgs e)
        {
            PizzarronForm pizarron = new PizzarronForm();
            pizarron.Show();

            this.Hide();
        }

        private void pictureBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
