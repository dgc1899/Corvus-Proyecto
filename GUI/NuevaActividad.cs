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
    public partial class NuevaActividad : Form
    {
        public int idGrupo { get; set; }
        public NuevaActividad()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            ActividadModel actividadModel;
            ActividadController actividadController;
            bool verify;
            try
            {
                if (txtTitulo.Text != "" && txtDesc.Text != "")
                {
                    actividadModel = new ActividadModel();
                    actividadController = new ActividadController();

                    actividadModel.NombreActividad = txtTitulo.Text.Trim();
                    actividadModel.DescActividad = txtDesc.Text.Trim();
                    actividadModel.FechaActividad = DateTime.Now;
                    actividadModel.IdGrupo = idGrupo;

                    verify= actividadController.Agregar(actividadModel);
                    if(verify == true)
                    {
                        MessageBox.Show("Actividad agregada");
                        GrupoForm grupoForm = new GrupoForm();
                        grupoForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Intentar de nuevo");

                    }
                }
                else
                {
                    MessageBox.Show("Llenar todos los campos");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
