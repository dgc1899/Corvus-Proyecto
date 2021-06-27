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
    public partial class GrupoForm : Form
    {
        public int idGrupo{get;set;}

        public GrupoForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            GruposForma grupos = new GruposForma();
            grupos.Show();
            this.Hide();
        }

        private void GrupoForm_Load(object sender, EventArgs e)
        {
            LLenarListaActividades(idGrupo);
        }

        void LLenarListaActividades(int idGrupo)
        {
            //Poblar la lista de actividades
            try
            {
                listActividades.DataSource = ActividadController.GetActividadesByGrupo(idGrupo);
                listActividades.DisplayMember = "nombreActividad";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message,ex);
            }
        }

        private void cmdActividades_Click(object sender, EventArgs e)
        {
            ActividadesGestionar actividadesGestionar = new ActividadesGestionar();
            actividadesGestionar.idGrupo = this.idGrupo;
            actividadesGestionar.Show();
            this.Hide();
        }

        private void cmdEval_Click(object sender, EventArgs e)
        {
            EvaluacionesGestionar evaluacionesGestionar = new EvaluacionesGestionar();
            evaluacionesGestionar.idGrupo = this.idGrupo;
            evaluacionesGestionar.Show();
            this.Hide();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            LLenarListaActividades(idGrupo);
        }

        private void cmdMiembros_Click(object sender, EventArgs e)
        {
            Miembros_de_Grupo miembros_De_Grupo = new Miembros_de_Grupo();
            miembros_De_Grupo.idGrupo = this.idGrupo;
            miembros_De_Grupo.Show();
            this.Hide();
        }

        private void cmdOpciones_Click(object sender, EventArgs e)
        {
            OpcionesForm opcionesForm = new OpcionesForm();
            opcionesForm.idGrupo = this.idGrupo;
            opcionesForm.Show();
            this.Hide();
        }
    }
}
