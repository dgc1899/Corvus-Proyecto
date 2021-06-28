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
    public partial class EvaluacionesGestionar : Form
    {
        ExamenModel examenModel;
        ExamenController examenController;
        public int idGrupo { get; set; }
        public EvaluacionesGestionar()
        {
            InitializeComponent();
        }

        private void EvaluacionesGestionar_Load(object sender, EventArgs e)
        {
            PoblarDataGrid();
        }

        private void PoblarDataGrid()
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
            //Eliminar el registro seleccionado
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esto va a eliminar el registro seleccionado", "¿Seguro que desea eliminar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    examenModel = new ExamenModel();
                    examenController = new ExamenController();

                    examenModel.IdActividad = Convert.ToInt32(gridEvaluaciones.CurrentRow.Cells["idExamen"].Value);
                    bool output = examenController.Eliminar(examenModel);

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
        //Modificar una evaluacion

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esto va a modificar el registro seleccionado", "¿Seguro que desea modificar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    examenController = new ExamenController();
                    examenModel = new ExamenModel();

                    examenModel.IdActividad = Convert.ToInt32(gridEvaluaciones.CurrentRow.Cells["idExamen"].Value);
                    examenModel.NombreActividad = gridEvaluaciones.CurrentRow.Cells["nombreExamen"].Value.ToString();
                    examenModel.DescActividad = gridEvaluaciones.CurrentRow.Cells["descExamen"].Value.ToString();
                    examenModel.UnidadExamen = Convert.ToInt32(gridEvaluaciones.CurrentRow.Cells["unidadExamen"].Value);
                    examenModel.FechaLimiteExamen = gridEvaluaciones.CurrentRow.Cells["fechaLimiteExamen"].Value.ToString();

                    bool verify=examenController.Modificar(examenModel);
                    if (verify == true)
                    {
                        MessageBox.Show("Registro modificado");
                        PoblarDataGrid();
                    }
                    else
                        MessageBox.Show("Intentar de nuevo");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message,ex);
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
