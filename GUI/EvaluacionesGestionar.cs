using Corvus_Proyecto.Controllers;
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
        public int idGrupo { get; set; }
        public EvaluacionesGestionar()
        {
            InitializeComponent();
        }

        private void EvaluacionesGestionar_Load(object sender, EventArgs e)
        {
            //Poblar DataGrid de Examenes
            ExamenController examenController = new ExamenController();
            gridEvaluaciones.DataSource = examenController.GetExamenes(idGrupo);
        }

        private void cmdNuevaEvaluacion_Click(object sender, EventArgs e)
        {
            //Nueva actividad
            Nueva_evaluación nueva_Evaluación = new Nueva_evaluación();
            nueva_Evaluación.idGrupo = this.idGrupo;
            nueva_Evaluación.Show();
            this.Hide();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            GrupoForm grupoForm = new GrupoForm();
            grupoForm.idGrupo = this.idGrupo;
            grupoForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActividadModel actividadModel;
            ActividadController actividadController;
            //Eliminar el registro seleccionado
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esto va a eliminar el registro seleccionado", "¿Seguro que desea eliminar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
    }
}
