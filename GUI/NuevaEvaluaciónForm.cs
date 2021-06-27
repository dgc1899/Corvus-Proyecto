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
    public partial class Nueva_evaluación : Form
    {
        public int idGrupo { get; set; }
        public Nueva_evaluación()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExamenModel examenModel = new ExamenModel();
            ExamenController examenController = new ExamenController();
            try
            {
                bool verify;
                examenModel.NombreActividad = txtnombre.Text.Trim();
                examenModel.DescActividad = txtDesc.Text.Trim();
                examenModel.UnidadExamen = Convert.ToInt32(txtUnidad.Text.Trim());
                examenModel.FechaActividad = DateTime.Now;
                examenModel.FechaLimiteExamen = datepickerFecha.Text;
                examenModel.IdGrupo = this.idGrupo;

                verify=examenController.Agregar(examenModel);

                if (verify == true)
                {
                    MessageBox.Show("Examen agregado");
                    EvaluacionesGestionar evaluacionesGestionar = new EvaluacionesGestionar();
                    evaluacionesGestionar.idGrupo = this.idGrupo;
                    evaluacionesGestionar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Intentar de nuevo");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
