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
                        grupoForm.idGrupo = this.idGrupo;
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

        private void pictureBox_cerrar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NuevaActividad_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_minimizar_Click(object sender, EventArgs e)
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
    }
}
