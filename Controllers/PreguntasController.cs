using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus_Proyecto.Controllers
{
    public class PreguntasController : BaseController
    {
        public PreguntasController(string connString)
        {
            _connString = connString;
        }
    }
}
