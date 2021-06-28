using Corvus_Proyecto.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corvus_Proyecto.Controllers;
using System.Data.SQLite;

namespace Corvus_Proyecto.GUI
{
    public partial class GruposForma : Form
    {
        public GruposForma()
        {
            InitializeComponent();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void GruposForma_Load(object sender, EventArgs e)
        {
            //Llama metodo poblar Panel
            Poblar();
        }

        private void Poblar()
        {
            int idDocente;
            int noIconos=0;
            int j = 0;
            idDocente= SqliteDataAccess.GetIdDocente();

            //Get no. de iconos a visualizar
            noIconos = GrupoController.GetGruposByDocente(idDocente,noIconos);
            BotonAula[] botonesAula = new BotonAula[noIconos];

            for (int i = 0; i < botonesAula.Length; i++)
            {
                botonesAula[i] = new BotonAula();
                botonesAula[i].CambiarNombre(GrupoController.GetNombreGrupo(idDocente,j));
                botonesAula[i].SetIdAula(GrupoController.GetIdGrupo(idDocente, j));
                j++;

                if (PnlIconos.Controls.Count < 0)
                {
                    PnlIconos.Controls.Clear();
                }
                else
                {
                    PnlIconos.Controls.Add(botonesAula[i]);

                    //Generar Event handler para cada icono
                   botonesAula[i].Click += new EventHandler(BotonAula_Click);
                }
            }
          
            

        }

         void BotonAula_Click(object sender, EventArgs e)
        {
            BotonAula boton = (BotonAula)sender;
            MostrarFormaGrupo(boton.GetIdAula());
            

        }

        //Metodo para que los botones generados dinamicamente abran su respectiva ventana de grupo
        void MostrarFormaGrupo(int idAula)
        {
            GrupoForm grupo = new GrupoForm();
            grupo.idGrupo = idAula;
            grupo.Show();
            this.Hide();
        }

        public int GetIdentificador()
        {
            int identificador;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand("select idDocente from Docentes where nombreDocente = @nombreDocente", connection))
                    {
                        connection.Open();
                        
                        using (SQLiteDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    identificador = Convert.ToInt32(dr["idDocente"]);
                                    MessageBox.Show(identificador.ToString());
                                    return identificador;
                                }
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GrupoNuevoForm grupoNuevoForm = new GrupoNuevoForm();
            this.Hide();
            grupoNuevoForm.Show();
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
