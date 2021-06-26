using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corvus_Proyecto.CustomControls
{
    public partial class BotonAula : UserControl
    {
        public string nombreAula { get; set; }
        public int idAula { get; set; }

        public BotonAula()
        {
            InitializeComponent();
        }

        public void SetIdAula(int idGrupo)
        {
            idAula = idGrupo;
        }

        public int GetIdAula()
        {
            return idAula;
        }
        public void CambiarNombre(string nombre)
        {
            nombreAula = nombre;
            lblText.Text = nombreAula;
        }

        //Mouse Hover
        private void BotonAula_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void BotonAula_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);

        }
    }
}
