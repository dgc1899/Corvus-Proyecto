using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corvus_Proyecto.Models;

namespace Corvus_Proyecto.Controllers
{
    public class ActividadController:BaseController
    {
        public ActividadController(string connString)
        {
            _connString = connString;
        }
    }
}
