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
    public partial class EvaluacionesGestionar : Form
    {
        public EvaluacionesGestionar()
        {
            InitializeComponent();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            GrupoForm grupoFor = new();
            this.Hide();
            grupoFor.Show();
        }

        private void cmdNuevaEvaluacion_Click(object sender, EventArgs e)
        {
            Nueva_evaluación nuevaEvaluacionForm = new();
            this.Hide();
            nuevaEvaluacionForm.Show();
        }

        private void EvaluacionesGestionar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
