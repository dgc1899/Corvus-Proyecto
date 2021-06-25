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

            idDocente= SqliteDataAccess.GetIdDocente();

            //Get no. de iconos a visualizar
            noIconos = GrupoController.GetGruposByDocente(idDocente,noIconos);
            BotonAula[] botonesAula = new BotonAula[noIconos];

            for (int i = 0; i < botonesAula.Length; i++)
            {
                botonesAula[i] = new BotonAula();
                botonesAula[i].CambiarNombre(GrupoController.GetNombreGrupo(idDocente));

                if (PnlIconos.Controls.Count < 0)
                {
                    PnlIconos.Controls.Clear();
                }
                else
                {
                    PnlIconos.Controls.Add(botonesAula[i]);
                }
            }
          
            

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
    }
}
