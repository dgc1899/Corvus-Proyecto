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
    public partial class Miembros_de_Grupo : Form
    {
        public int idGrupo { get; set; }
        public Miembros_de_Grupo()
        {
            InitializeComponent();
        }

        //Metodo para poblar el Listview
        void PoblarLista()
        {
            AlumnoController alumnoController = new AlumnoController();

            gridAlumnos.DataSource = alumnoController.GetAlumnos(idGrupo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoAlumnoForm nuevoAlumnoForm = new NuevoAlumnoForm();
            nuevoAlumnoForm.Show();
            nuevoAlumnoForm.idGrupo = this.idGrupo;
            this.Hide();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            GrupoForm grupoForm = new GrupoForm();
            grupoForm.idGrupo = this.idGrupo;
            grupoForm.Show();
            this.Hide();
        }

        private void Miembros_de_Grupo_Load(object sender, EventArgs e)
        {
            PoblarLista();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            //Eliminar un alumno
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esto va a eliminar el registro seleccionado", "¿Seguro que desea eliminar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AlumnoModel alumnoModel = new AlumnoModel();
                    AlumnoController alumnoController = new AlumnoController();

                    alumnoModel.NoControl = Convert.ToInt32(gridAlumnos.CurrentRow.Cells["noControl"].Value);
                    bool output = alumnoController.EliminarDeGrupo(alumnoModel);
                    if (output == true)
                    {
                        bool output2 = alumnoController.Eliminar(alumnoModel);
                        if (output2 == true)
                        {
                            MessageBox.Show("Alumno eliminado");
                            PoblarLista();
                        }

                    }
                    else
                        MessageBox.Show("Algo ha salido mal");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void pictureBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
