using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus_Proyecto.Model
{
    public class GrupoModel
    {
        public int IdGrupo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdDocente { get; set; }

        public List<AlumnoModel> alumnoModels = new List<AlumnoModel>();

        public List<ActividadModel> actividadModels = new List<ActividadModel>();
    }
}
