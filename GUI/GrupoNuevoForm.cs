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
    public partial class GrupoNuevoForm : Form
    {
        GrupoModel grupo = new GrupoModel();
        GrupoController grupoController;

        public GrupoNuevoForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            //Agregar nuevo grupo
            int docentelogeado = SqliteDataAccess.GetIdDocente();
            bool verify = false;
            try
            {
                if (txtDesc.Text != "" && txtNombre.Text != "" && txtPeriodo.Text != "")
                {
                    grupo.IdDocente = docentelogeado;
                    grupo.Nombre = txtNombre.Text.Trim();
                    grupo.Periodo = txtPeriodo.Text.Trim();
                    grupo.Descripcion = txtDesc.Text.Trim();
                    grupoController = new GrupoController();
                    verify=grupoController.Agregar(grupo);

                    if (verify == true)
                    {
                        MessageBox.Show("Registro agregado");
                        GruposForma gruposForma = new GruposForma();
                        gruposForma.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Intentar de nuevo");
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }


        }
    }
}
