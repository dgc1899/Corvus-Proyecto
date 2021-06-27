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
    public partial class OpcionesForm : Form
    {
        public int idGrupo { get; set; }
        GrupoModel grupoModel;
        GrupoController grupoController;
        public OpcionesForm()
        {
            InitializeComponent();
        }

        private void OpcionesForm_Load(object sender, EventArgs e)
        {
            PoblarTextBox();
        }
        //Metodo para poblar los textbox con la info. del grupo ya existente en la bd
        void PoblarTextBox()
        {
            grupoModel= new GrupoModel();
           grupoController= new GrupoController();

            grupoModel=grupoController.GetGrupos(idGrupo);
            txtNombre.Text = grupoModel.Nombre;
            txtDesc.Text = grupoModel.Descripcion;
            txtPeriodo.Text = grupoModel.Periodo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            GrupoForm grupo = new GrupoForm();
            grupo.idGrupo = this.idGrupo;
            grupo.Show();
            this.Hide();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            //Aplicar los valores de los textbox y subirlos a la base de datos, en caso de que haya modificaciones
            grupoModel = new GrupoModel();
            grupoController = new GrupoController();

            grupoModel.Nombre = txtNombre.Text.Trim();
            grupoModel.Descripcion = txtDesc.Text.Trim();
            grupoModel.Periodo = txtPeriodo.Text.Trim();
            grupoModel.IdGrupo = idGrupo;

            try
            {
                bool output =grupoController.Modificar(grupoModel);
                if (output == true)
                {
                    MessageBox.Show("Grupo modificado");
                    GrupoForm grupo = new GrupoForm();
                    grupo.idGrupo = this.idGrupo;
                    grupo.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Intentar de nuevo");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message,ex);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //Eliminar el grupo
            grupoModel = new GrupoModel();
            grupoController = new GrupoController();

            DialogResult dialogResult = MessageBox.Show("Esto va a eliminar el registro seleccionado", "¿Seguro que desea eliminar?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                grupoModel.IdGrupo = idGrupo;
                grupoController.Eliminar(grupoModel);
                MessageBox.Show("Grupo eliminado");
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
}
