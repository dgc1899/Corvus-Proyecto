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
    public partial class ActividadesGestionar : Form
    {
        ActividadController actividadController;
        int idGrupo;
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
            nuevaActividad.Show();
            this.Hide();
        }
    }
}
