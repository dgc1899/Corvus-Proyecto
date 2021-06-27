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
    public partial class NuevoAlumnoForm : Form
    {
        public int idGrupo { get; set; }
        public NuevoAlumnoForm()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            //Agegar un nuevo alumnos
            AlumnoModel alumnoModel;
            AlumnoController alumnoController;

            try
            {
                if (txtNombre.Text != "" && txtApPat.Text != "" && txtApMat.Text != "" && txtCorreo.Text != "")
                {
                    alumnoModel = new AlumnoModel();
                    alumnoController = new AlumnoController();

                    alumnoModel.Nombre = txtNombre.Text.Trim();
                    alumnoModel.ApPaterno = txtApPat.Text.Trim();
                    alumnoModel.ApMaterno = txtApMat.Text.Trim();
                    alumnoModel.CorreoAlumno = txtCorreo.Text.Trim();

                    int noControl=alumnoController.Agregar(alumnoModel);
                    if (noControl !=0)
                    {
                       bool verify= alumnoController.AgregarAlGrupo(noControl,idGrupo);
                        if (verify == true)
                        {
                            MessageBox.Show("Alumno agregado");
                            Miembros_de_Grupo miembros = new Miembros_de_Grupo();
                            miembros.idGrupo = this.idGrupo;
                            miembros.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Error al insertar en el grupo");
                    }
                    else
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
