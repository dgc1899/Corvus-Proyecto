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
    public partial class NuevaActividad : Form
    {
        public NuevaActividad()
        {
            InitializeComponent();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            ActividadesGestionar actividadForm = new();
            this.Hide();
            actividadForm.Show();
        }

        private void NuevaActividad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
