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
    public partial class Nueva_evaluación : Form
    {
        public Nueva_evaluación()
        {
            InitializeComponent();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            EvaluacionesGestionar evuaGesForm = new ();
            this.Hide();
            evuaGesForm.Show();
        }

        private void Nueva_evaluación_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
