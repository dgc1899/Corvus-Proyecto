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
    public partial class GrupoForm : Form
    {
        public GrupoForm()
        {
            InitializeComponent();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            GruposForma grupos = new GruposForma();
            grupos.Show();
            this.Hide();
        }

        private void cmdActividades_Click(object sender, EventArgs e)
        {
            ActividadesGestionar actividadesForm = new();
            this.Hide();
            actividadesForm.Show();
        }

        private void cmdEval_Click(object sender, EventArgs e)
        {
            EvaluacionesGestionar evaForm = new();
            this.Hide();
            evaForm.Show();
        }

        private void cmdMiembros_Click(object sender, EventArgs e)
        {
            Miembros_de_Grupo miembrosForm = new();
            this.Hide();
            miembrosForm.Show();
        }

        private void cmdOpciones_Click(object sender, EventArgs e)
        {
            OpcionesForm opForm = new();
            this.Hide();
            opForm.Show();
        }

        private void GrupoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
