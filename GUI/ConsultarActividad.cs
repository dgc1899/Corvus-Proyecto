using Corvus_Proyecto.Controllers;
using Corvus_Proyecto.Model;
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
    public partial class ConsultarActividad : Form
    {
        public int noActividad { get; set; }
        public int idGrupo { get; set; }

        public ConsultarActividad()
        {
            InitializeComponent();
        }

        private void ConsultarActividad_Load(object sender, EventArgs e)
        {
            //Llenar los textboxes
            PoblarTextBox();
        }

        void PoblarTextBox()
        {
            ActividadController actividadController = new ActividadController();
            ActividadModel actividadModel = new ActividadModel();

            actividadModel.IdActividad = this.noActividad;

            ActividadModel aux = actividadController.GetDetallesActividad(actividadModel);

            txtTitulo.Text = aux.NombreActividad.ToString();
            txtDesc.Text = aux.DescActividad.ToString();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            GrupoForm grupoForm = new GrupoForm();
            grupoForm.idGrupo = this.idGrupo;
            grupoForm.Show();
            this.Hide();
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

        private void pictureBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
