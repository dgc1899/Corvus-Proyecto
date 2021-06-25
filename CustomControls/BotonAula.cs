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
        public BotonAula()
        {
            InitializeComponent();
        }

        public void CambiarNombre(string nombre)
        {
            nombreAula = nombre;
            lblText.Text = nombreAula;
        }
    }
}
