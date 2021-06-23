using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corvus_Proyecto.Models;

namespace Corvus_Proyecto.Model
{
    public class ExamenModel:ActividadModel
    {
        public List<PreguntasModel> preguntasModels = new List<PreguntasModel>();
    }
}
