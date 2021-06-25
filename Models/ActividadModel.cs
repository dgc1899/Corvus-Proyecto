using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus_Proyecto.Model
{
    public class ActividadModel
    {   
        public int IdActividad { get; set; }
        public int IdGrupo { get; set; }
        public string NombreActividad { get; set; }
        public DateTime FechaActividad { get; set; }
        public string DescActividad { get; set; }
    }
}
