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
    public partial class Miembros_de_Grupo : Form
    {
        public Miembros_de_Grupo()
        {
            InitializeComponent();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            GrupoForm grupoFor = new();
            this.Hide();
            grupoFor.Show();
        }

        private void Miembros_de_Grupo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
