using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corvus_Proyecto.GUI.Pizarron;
using Corvus_Proyecto.Models;

namespace Corvus_Proyecto.GUI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            getNombreDocente();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForma = new LoginForm();
            this.Hide();
            loginForma.Show();
        }

        private void cmdGrupos_Click(object sender, EventArgs e)
        {
            abrirGrupos();
        }
        private void label_Grupos_Click(object sender, EventArgs e)
        {
            abrirGrupos();
        }


        private void cmdPizarron_Click(object sender, EventArgs e)
        {
            abrirPizarron();
        }

        private void label_Pizarron_Click(object sender, EventArgs e)
        {
            abrirPizarron();
        }

        private void abrirPizarron() 
        {
            PizzarronForm pizarron = new ();
            pizarron.Show();
            //this.Hide();
        }

        private void abrirGrupos()
        {
            GruposForma gruposForma = new GruposForma();
            this.Hide();
            gruposForma.Show();
        }

        private void getNombreDocente()
        {
            int idDocente;
            idDocente = SqliteDataAccess.GetIdDocente();
            String nombreDocnete = "Pepito";
            /*Agregar get del nombre del docente*/
            labelNombreDocente.Text = nombreDocnete;
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
