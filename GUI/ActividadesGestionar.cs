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
    public partial class ActividadesGestionar : Form
    {
        ActividadController actividadController;
        ActividadModel actividadModel;
        public int idGrupo { get; set; }
        public ActividadesGestionar()
        {
            InitializeComponent();
        }

        private void ActividadesGestionar_Load(object sender, EventArgs e)
        {
            //Poblar el DataGrid
            PoblarDataGrid();
        }

        private void PoblarDataGrid()
        {
             actividadController= new ActividadController();
            gridActividades.DataSource=actividadController.GetActividades(idGrupo);
        }

        private void cmdNuevaActividad_Click(object sender, EventArgs e)
        {
            //Nueva actividad
            NuevaActividad nuevaActividad = new NuevaActividad();
            nuevaActividad.idGrupo = this.idGrupo;
            nuevaActividad.Show();
            this.Hide();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            GrupoForm grupoForm = new GrupoForm();
            grupoForm.idGrupo = this.idGrupo;
            grupoForm.Show();
            this.Hide();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
           
            //Eliminar el registro seleccionado
            try
            {
               DialogResult dialogResult= MessageBox.Show("Esto va a eliminar el registro seleccionado","¿Seguro que desea eliminar?", MessageBoxButtons.YesNo);
                if (dialogResult==DialogResult.Yes)
                {
                    actividadModel = new ActividadModel();
                    actividadController = new ActividadController();

                    actividadModel.IdActividad = Convert.ToInt32(gridActividades.CurrentRow.Cells["noActividad"].Value);
                    bool output = actividadController.Eliminar(actividadModel);

                    if (output == true)
                    {
                        MessageBox.Show("Registro eliminado");
                        PoblarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Intenta de nuevo");
                    }

                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esto va a modificar el registro seleccionado", "¿Seguro que desea modificar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    actividadModel = new ActividadModel();
                    actividadController = new ActividadController();

                    actividadModel.IdActividad = Convert.ToInt32(gridActividades.CurrentRow.Cells["noActividad"].Value);
                    actividadModel.NombreActividad = gridActividades.CurrentRow.Cells["nombreActividad"].Value.ToString();
                    actividadModel.DescActividad = gridActividades.CurrentRow.Cells["descActividad"].Value.ToString();

                    bool output = actividadController.Modificar(actividadModel);

                    if (output == true)
                    {
                        MessageBox.Show("Registro modificado");
                        PoblarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Intenta de nuevo");
                    }

                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
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
