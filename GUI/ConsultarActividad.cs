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
    }
}
