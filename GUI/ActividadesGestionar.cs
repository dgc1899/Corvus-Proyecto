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
    public partial class ActividadesGestionar : Form
    {
        public ActividadesGestionar()
        {
            InitializeComponent();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            GrupoForm grupoFor = new();
            this.Hide();
            grupoFor.Show();
        }

        private void ActividadesGestionar_Load(object sender, EventArgs e)
        {

        }

        private void cmdNuevaActividad_Click(object sender, EventArgs e)
        {
            NuevaActividad actividadForm = new();
            this.Hide();
            actividadForm.Show();
        }

        private void ActividadesGestionar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
