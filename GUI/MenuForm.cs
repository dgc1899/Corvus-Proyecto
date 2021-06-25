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
    }
}
