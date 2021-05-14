using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus_Proyecto.GUI.Pizarron
{
    public partial class ColorSelector : Component
    {
        public ColorSelector()
        {
            InitializeComponent();
        }

        public ColorSelector(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
